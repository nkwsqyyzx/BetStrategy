
namespace WSQ.CSharp.Net
{
    /// <summary>
    /// http request finished callback.
    /// </summary>
    /// <param name="succeeded">true if the request finished successfully.</param>
    /// <param name="response">the response string.</param>
    /// <param name="errorResult">the error reason</param>
    public delegate void RequestFinished(bool succeeded, string response, string errorResult);
}