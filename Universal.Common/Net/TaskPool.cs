using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace WSQ.CSharp.Net
{
    /// <summary>
    /// task pool to handle all task.
    /// </summary>
    internal class TaskPool
    {
        protected class QueueItem
        {
            public string Url;
            public HttpMethod Method;
            public RequestFinished Action;

            // post.
            public List<KeyValuePair<string, string>> PostData;
        }

        private readonly int MAX_TASK_COUNT = 3;

        private static TaskPool _instance;
        private AutoResetEvent _resetEvent;
        private int _taskCount;
        private bool _isThreadActivated;
        private Queue<QueueItem> _waitingQueue;
        private List<HttpTask> _tasks;
        private object _lock;

        /// <summary>
        /// instance task pool.
        /// </summary>
        public static TaskPool Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(TaskPool))
                    {
                        if (_instance == null)
                        {
                            _instance = new TaskPool();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        private TaskPool()
        {
            _resetEvent = new AutoResetEvent(false);
            _waitingQueue = new Queue<QueueItem>();
            _tasks = new List<HttpTask>();
            _lock = new object();
            _taskCount = MAX_TASK_COUNT;
            _isThreadActivated = false;
        }

        /// <summary>
        /// get web content
        /// </summary>
        /// <param name="url">requested url</param>
        /// <param name="action">callback when finished</param>
        public void Request(string url, HttpMethod method, List<KeyValuePair<string, string>> httpPostData, RequestFinished action)
        {
            QueueItem item = new QueueItem() { Action = action, Url = url, Method = method, PostData = httpPostData };
            AddQueueItem(item);
        }

        /// <summary>
        /// upload a file
        /// </summary>
        /// <param name="url">requested url</param>
        /// <param name="httpPostData">post data</param>
        /// <param name="fileUploadData">file data</param>
        /// <param name="fileFieldName">file name in header</param>
        /// <param name="fileName">file name</param>
        /// <param name="action">callback when finished</param>
        public void RequestUploadFile(string url, List<KeyValuePair<string, string>> httpPostData, byte[] fileUploadData, string fileFieldName, string fileName, RequestFinished action)
        {
            QueueItem item = new QueueItem()
            {
                Method = HttpMethod.Post,
                Action = action,
                Url = url,
                PostData = httpPostData
            };
            AddQueueItem(item);
        }

        /// <summary>
        /// post a new task to the pool.
        /// </summary>
        /// <param name="item"></param>
        private void AddQueueItem(QueueItem item)
        {
            BackgroundWorker worker = null;
            lock (_lock)
            {
                _waitingQueue.Enqueue(item);
                if (!_isThreadActivated)
                {
                    _isThreadActivated = true;
                    worker = new BackgroundWorker();
                }
            }

            if (worker != null)
            {
                worker.DoWork += ((send, ev) => StartThread());
                worker.RunWorkerCompleted += ((s, e) =>
                {
                    lock (_lock)
                    {
                        _isThreadActivated = false;
                    }
                });
                worker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Cancel all tasks
        /// </summary>
        public void CancelAll()
        {
            lock (_lock)
            {
                _isThreadActivated = false;
                _waitingQueue.Clear();
            }
            lock (_lock)
            {
                foreach (HttpTask item in _tasks)
                {
                    item.Cancel();
                }
            }
        }

        /// <summary>
        /// Create a thread from item queue
        /// </summary>
        private void StartThread()
        {
            while (true)
            {
                if (_taskCount == 0)
                {
                    _resetEvent.WaitOne();
                }
                QueueItem item = null;

                lock (_lock)
                {
                    if (!_isThreadActivated || _waitingQueue.Count == 0)
                    {
                        break;
                    }
                    item = _waitingQueue.Dequeue();
                    Interlocked.Decrement(ref _taskCount);
                }

                // Get the task
                var task = GetTask(item);
                task.Start();

                lock (_lock)
                {
                    _tasks.Add(task);
                }

                Thread.Sleep(1);
            }
        }

        /// <summary>
        /// Get a task from a queued item
        /// </summary>
        /// <param name="item">queue request item</param>
        /// <returns>task</returns>
        private HttpTask GetTask(QueueItem item)
        {
            HttpTask httpTask = null;

            if (item.Method == HttpMethod.Get)
            {
                httpTask = new GetTextHttpTask(item.Url);
            }
            else
            {
                httpTask = new PostTextHttpTask(item.Url, item.PostData);
            }

            httpTask.HttpRequestCompleted += (state, stream, error) =>
            {

                lock (_lock)
                {
                    _tasks.Remove(httpTask);
                }
                if (_taskCount == 0)
                {
                    _resetEvent.Set();
                }
                Interlocked.Increment(ref _taskCount);

                item.Action(state, stream, error);
            };
            return httpTask;
        }
    }
}
