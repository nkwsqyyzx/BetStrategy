using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using WSQ.CSharp.Helper;

namespace BetStrategy.ViewModels
{
    public class TestViewModel : BaseViewModel
    {
        private PreferResultToStringConverter converter = new PreferResultToStringConverter();

        private ObservableCollection<Recommend> _recommends = null;
        public ObservableCollection<Recommend> Recommends
        {
            get
            {
                return _recommends;
            }
        }

        private ObservableCollection<Person> _topPerson = null;
        public ObservableCollection<Person> TopPerson
        {
            get
            {
                return _topPerson;
            }
        }

        private ObservableCollection<YieldRoiPerson> _topYieldRoiPerson = null;
        public ObservableCollection<YieldRoiPerson> TopYieldRoiPerson
        {
            get
            {
                return _topYieldRoiPerson;
            }
        }

        public TestViewModel()
        {
            InitRecommends();
            InitTopPerson();
            InitTopYieldRoiPerson();
        }

        private void InitRecommends()
        {
            _recommends = new ObservableCollection<Recommend>();
            _recommends.Add(new Recommend() { Time1 = "05-01 07:15", Host = "堤格雷", OddStake = "2/2.5球", Guest = "奧林匹亞", Prefer = "小球", Odds = 0.940f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 23:03", Person = "bin-bin" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:00", Host = "喜百年U20", OddStake = "球半/两球", Guest = "登地U20", Prefer = "喜百年U20", Odds = 0.920f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 23:02", Person = "回心融雪衣" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "平/半", Guest = "艾斯迪格拿", Prefer = "艾斯迪格拿", Odds = 0.860f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 23:01", Person = "不学无术" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "車斯曼", OddStake = "半球", Guest = "赫默爾亨普斯特德城", Prefer = "赫默爾亨普斯特德城", Odds = 0.800f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:57", Person = "sos73" });
            _recommends.Add(new Recommend() { Time1 = "05-01 07:15", Host = "堤格雷", OddStake = "平/半", Guest = "奧林匹亞", Prefer = "奧林匹亞", Odds = 1.020f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:56", Person = "茶居" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "米禾爾", OddStake = "平手", Guest = "水晶宮", Prefer = "水晶宮", Odds = 0.800f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:56", Person = "运达不来霉" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "菲爾德", OddStake = "半球", Guest = "盧沙奧林", Prefer = "菲爾德", Odds = 1.020f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:56", Person = "mzzzzzzm" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球/球半", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.890f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:55", Person = "西班牙王子" });
            _recommends.Add(new Recommend() { Time1 = "05-01 01:30", Host = "馬摩洛迪落日", OddStake = "平/半", Guest = "自由州星", Prefer = "馬摩洛迪落日", Odds = 0.970f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:54", Person = "大D哥" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:45", Host = "阿爾艾利開羅", OddStake = "半球", Guest = "索莫哈", Prefer = "索莫哈", Odds = 0.840f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:49", Person = "凤凰谷" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "伊斯特雷格", OddStake = "平/半", Guest = "多佛", Prefer = "多佛", Odds = 0.800f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:49", Person = "sweetcat" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球/球半", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.890f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:49", Person = "雪儿" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "切爾弗德", OddStake = "2.5/3球", Guest = "塞利斯貝瑞", Prefer = "小球", Odds = 0.800f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:44", Person = "春游记" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球/球半", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.880f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:42", Person = "jaddeking" });
            _recommends.Add(new Recommend() { Time1 = "05-01 01:30", Host = "馬摩洛迪落日", OddStake = "平/半", Guest = "自由州星", Prefer = "自由州星", Odds = 0.850f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:41", Person = "爷有旺仔" });
            _recommends.Add(new Recommend() { Time1 = "05-01 01:30", Host = "馬摩洛迪落日", OddStake = "平/半", Guest = "自由州星", Prefer = "馬摩洛迪落日", Odds = 0.970f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:28", Person = "重在参与" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "平/半", Guest = "艾斯迪格拿", Prefer = "艾斯迪格拿", Odds = 0.900f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:19", Person = "爽爽" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "艾青洽", OddStake = "平/半", Guest = "巴克利城", Prefer = "巴克利城", Odds = 0.900f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:15", Person = "提子味" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "平/半", Guest = "艾斯迪格拿", Prefer = "艾斯迪格拿", Odds = 0.900f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:13", Person = "一天一点赢" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:00", Host = "普拉騰斯", OddStake = "2/2.5球", Guest = "瑪倫", Prefer = "小球", Odds = 0.880f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:12", Person = "天巧星燕青" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球/球半", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 1.050f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:11", Person = "不孕不育专家" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "菲爾德", OddStake = "半球", Guest = "盧沙奧林", Prefer = "盧沙奧林", Odds = 0.850f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:08", Person = "章鱼帝" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "平/半", Guest = "艾斯迪格拿", Prefer = "艾恩", Odds = 0.960f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:07", Person = "杀出个黎明" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球/球半", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 1.060f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:00", Person = "海里昙花" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "車斯曼", OddStake = "半球", Guest = "赫默爾亨普斯特德城", Prefer = "赫默爾亨普斯特德城", Odds = 0.800f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:58", Person = "十万火急" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:59", Host = "沃爾夫斯堡青年隊", OddStake = "2.5球", Guest = "雲達不萊梅青年隊", Prefer = "大球", Odds = 0.970f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:56", Person = "飞天神猪" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球/球半", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.860f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:55", Person = "zx01668" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:00", Host = "普拉騰斯", OddStake = "2/2.5球", Guest = "瑪倫", Prefer = "小球", Odds = 0.800f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:54", Person = "浪人心声" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "半球", Guest = "艾斯迪格拿", Prefer = "艾斯迪格拿", Odds = 0.980f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:50", Person = "余韵犹在" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "3.5球", Guest = "多特蒙德", Prefer = "小球", Odds = 0.830f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:46", Person = "小花" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.980f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:42", Person = "弹弓六" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.980f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:34", Person = "慢慢来" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "2.5/3球", Guest = "艾斯迪格拿", Prefer = "大球", Odds = 0.960f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:33", Person = "八月十日" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:59", Host = "沙巴罕", OddStake = "半球", Guest = "阿爾葛拉法", Prefer = "阿爾葛拉法", Odds = 1.020f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:30", Person = "童年" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "3.5球", Guest = "多特蒙德", Prefer = "小球", Odds = 0.830f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:20", Person = "人在美洲" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "BW林茲", OddStake = "2.5/3球", Guest = "卡芬堡", Prefer = "大球", Odds = 0.870f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:16", Person = "足球冠军" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "聖普爾頓", OddStake = "2.5/3球", Guest = "亞塔奇", Prefer = "大球", Odds = 0.890f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:14", Person = "无冕之王" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 0.930f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:11", Person = "木棉树" });
            _recommends.Add(new Recommend() { Time1 = "05-01 07:15", Host = "堤格雷", OddStake = "2/2.5球", Guest = "奧林匹亞", Prefer = "小球", Odds = 0.840f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:08", Person = "龙8啤酒" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "3.5球", Guest = "多特蒙德", Prefer = "小球", Odds = 0.830f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 21:06", Person = "黑客的态度" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "半球", Guest = "艾斯迪格拿", Prefer = "艾斯迪格拿", Odds = 0.980f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:58", Person = "我行我素" });
            _recommends.Add(new Recommend() { Time1 = "05-01 09:30", Host = "提華納", OddStake = "半/一", Guest = "彭美拉斯", Prefer = "提華納", Odds = 0.910f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:52", Person = "斌少" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 0.930f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:52", Person = "cxm383" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "3.5球", Guest = "多特蒙德", Prefer = "小球", Odds = 0.830f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:50", Person = "神一样的玩家" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:59", Host = "沙巴罕", OddStake = "2.5/3球", Guest = "阿爾葛拉法", Prefer = "小球", Odds = 1.010f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:43", Person = "乌龙波" });
            _recommends.Add(new Recommend() { Time1 = "05-01 07:15", Host = "堤格雷", OddStake = "2/2.5球", Guest = "奧林匹亞", Prefer = "小球", Odds = 0.840f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:39", Person = "钱龙大帝" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "BW林茲", OddStake = "受半球", Guest = "卡芬堡", Prefer = "卡芬堡", Odds = 0.900f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:37", Person = "辉煌先锋" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.980f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:37", Person = "segespa" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾爾雷恩", OddStake = "2.5/3球", Guest = "希拉爾", Prefer = "大球", Odds = 0.850f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:36", Person = "yuelao200" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "半球", Guest = "艾斯迪格拿", Prefer = "艾斯迪格拿", Odds = 0.980f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:25", Person = "神算子" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "BW林茲", OddStake = "受半球", Guest = "卡芬堡", Prefer = "卡芬堡", Odds = 0.900f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 20:00", Person = "瑪莉皇后2號郵輪" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "2.5/3球", Guest = "艾斯迪格拿", Prefer = "小球", Odds = 0.900f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:26", Person = "红日" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "哈特堡格", OddStake = "2.5/3球", Guest = "路斯登洛", Prefer = "小球", Odds = 0.900f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:24", Person = "彩世界花园" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "3.5球", Guest = "多特蒙德", Prefer = "小球", Odds = 0.830f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:20", Person = "大头" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.980f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:19", Person = "xytlove" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "SV格羅迪格", OddStake = "2.5/3球", Guest = "第一維也納", Prefer = "大球", Odds = 0.880f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:19", Person = "独角刺龙" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 0.930f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:18", Person = "苦楝鸟" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:59", Host = "沙巴罕", OddStake = "2.5/3球", Guest = "阿爾葛拉法", Prefer = "大球", Odds = 0.850f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:16", Person = "飞天戟" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:00", Host = "阿爾艾利吉達(中)", OddStake = "球半", Guest = "納薩SC", Prefer = "阿爾艾利吉達(中)", Odds = 0.880f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:13", Person = "中奖" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "印戈斯塔德青年隊", OddStake = "2.5/3球", Guest = "拜仁慕尼黑青年隊", Prefer = "大球", Odds = 0.860f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:10", Person = "香鸡脚" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "哈特堡格", OddStake = "平/半", Guest = "路斯登洛", Prefer = "路斯登洛", Odds = 0.940f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:04", Person = "为梦等你" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "BW林茲", OddStake = "受半球", Guest = "卡芬堡", Prefer = "卡芬堡", Odds = 0.900f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 19:03", Person = "北风呼啸" });
            _recommends.Add(new Recommend() { Time1 = "05-01 07:15", Host = "堤格雷", OddStake = "2/2.5球", Guest = "奧林匹亞", Prefer = "小球", Odds = 0.840f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 18:39", Person = "一场成名" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 0.930f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 18:32", Person = "冷云" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "中央海岸", OddStake = "2.5球", Guest = "柏雷素爾", Prefer = "大球", Odds = 1.060f, Result = "0-3", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 18:20", Person = "东北球王" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "3.5球", Guest = "多特蒙德", Prefer = "大球", Odds = 1.060f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 18:13", Person = "森林" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "水原三星", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 18:12", Person = "纽约红牛" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "中央海岸", OddStake = "半/一", Guest = "柏雷素爾", Prefer = "中央海岸", Odds = 0.940f, Result = "0-3", PreferResult = (PreferResult)converter.ConvertBack("输盘", typeof(PreferResult), null, null), Time2 = "04-30 18:12", Person = "0度心凉" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "3.5球", Guest = "多特蒙德", Prefer = "小球", Odds = 0.830f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 18:08", Person = "lili369" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "中央海岸", OddStake = "2.5球", Guest = "柏雷素爾", Prefer = "大球", Odds = 1.060f, Result = "0-3", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 18:04", Person = "身不由己" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "水原三星", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 17:49", Person = "asd3388" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "廣島三箭", OddStake = "平手", Guest = "北京國安", Prefer = "北京國安", Odds = 0.900f, Result = "0-0", PreferResult = (PreferResult)converter.ConvertBack("走水", typeof(PreferResult), null, null), Time2 = "04-30 17:49", Person = "歡樂今宵" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "浦項制鐵", OddStake = "半/一", Guest = "賓約哥", Prefer = "賓約哥", Odds = 0.820f, Result = "1-1", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 17:49", Person = "帅的躲家里" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "廣島三箭", OddStake = "平手", Guest = "北京國安", Prefer = "北京國安", Odds = 0.900f, Result = "0-0", PreferResult = (PreferResult)converter.ConvertBack("走水", typeof(PreferResult), null, null), Time2 = "04-30 17:46", Person = "雪儿" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 0.930f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 17:43", Person = "跳舞草" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "浦項制鐵", OddStake = "半/一", Guest = "賓約哥", Prefer = "賓約哥", Odds = 0.820f, Result = "1-1", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 17:43", Person = "轻轻巧巧" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 0.930f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 17:42", Person = "东航空乘" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "水原三星", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 17:41", Person = "霸王龙" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "中央海岸", OddStake = "半/一", Guest = "柏雷素爾", Prefer = "柏雷素爾", Odds = 0.940f, Result = "0-3", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 17:41", Person = "LXF1234" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "廣島三箭", OddStake = "2球", Guest = "北京國安", Prefer = "大球", Odds = 0.900f, Result = "0-0", PreferResult = (PreferResult)converter.ConvertBack("输盘", typeof(PreferResult), null, null), Time2 = "04-30 17:39", Person = "笑妹" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "廣島三箭", OddStake = "平手", Guest = "北京國安", Prefer = "北京國安", Odds = 0.900f, Result = "0-0", PreferResult = (PreferResult)converter.ConvertBack("走水", typeof(PreferResult), null, null), Time2 = "04-30 17:33", Person = "一天一点赢" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:59", Host = "沙巴罕", OddStake = "半球", Guest = "阿爾葛拉法", Prefer = "沙巴罕", Odds = 0.860f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 17:32", Person = "iq" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "廣島三箭", OddStake = "平手", Guest = "北京國安", Prefer = "廣島三箭", Odds = 0.980f, Result = "0-0", PreferResult = (PreferResult)converter.ConvertBack("走水", typeof(PreferResult), null, null), Time2 = "04-30 17:31", Person = "lzzw0076" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "中央海岸", OddStake = "2.5球", Guest = "柏雷素爾", Prefer = "小球", Odds = 0.800f, Result = "0-3", PreferResult = (PreferResult)converter.ConvertBack("输盘", typeof(PreferResult), null, null), Time2 = "04-30 17:28", Person = "高原" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 0.930f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 17:20", Person = "老鬼看盘" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "貴州人和", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("输盘", typeof(PreferResult), null, null), Time2 = "04-30 17:18", Person = "默默非金" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球", Guest = "多特蒙德", Prefer = "皇家馬德里", Odds = 0.930f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 16:57", Person = "罗纳尔多" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "水原三星", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 16:54", Person = "贝多芬" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "浦項制鐵", OddStake = "2.5球", Guest = "賓約哥", Prefer = "大球", Odds = 1.060f, Result = "1-1", PreferResult = (PreferResult)converter.ConvertBack("输盘", typeof(PreferResult), null, null), Time2 = "04-30 16:53", Person = "朝鲜核武器" });
            _recommends.Add(new Recommend() { Time1 = "05-01 00:30", Host = "SV格羅迪格", OddStake = "2.5/3球", Guest = "第一維也納", Prefer = "大球", Odds = 0.880f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 16:51", Person = "墨斗红云" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "廣島三箭", OddStake = "平手", Guest = "北京國安", Prefer = "廣島三箭", Odds = 0.980f, Result = "0-0", PreferResult = (PreferResult)converter.ConvertBack("走水", typeof(PreferResult), null, null), Time2 = "04-30 16:37", Person = "阿麦的理想" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "3.5球", Guest = "多特蒙德", Prefer = "大球", Odds = 1.060f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 16:35", Person = "谷雨" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "廣島三箭", OddStake = "平手", Guest = "北京國安", Prefer = "北京國安", Odds = 0.900f, Result = "0-0", PreferResult = (PreferResult)converter.ConvertBack("走水", typeof(PreferResult), null, null), Time2 = "04-30 16:28", Person = "星星点灯" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "水原三星", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 16:26", Person = "wintion" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "浦項制鐵", OddStake = "半/一", Guest = "賓約哥", Prefer = "賓約哥", Odds = 0.820f, Result = "1-1", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 16:25", Person = "空山新雨" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "貴州人和", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("输盘", typeof(PreferResult), null, null), Time2 = "04-30 16:19", Person = "阿根廷" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:00", Host = "廣島三箭", OddStake = "平手", Guest = "北京國安", Prefer = "北京國安", Odds = 0.900f, Result = "0-0", PreferResult = (PreferResult)converter.ConvertBack("走水", typeof(PreferResult), null, null), Time2 = "04-30 16:16", Person = "西班牙王子" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:59", Host = "沙巴罕", OddStake = "半球", Guest = "阿爾葛拉法", Prefer = "沙巴罕", Odds = 0.860f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 16:12", Person = "lijin" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "貴州人和", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("输盘", typeof(PreferResult), null, null), Time2 = "04-30 16:04", Person = "黄金一代" });
            _recommends.Add(new Recommend() { Time1 = "04-30 18:30", Host = "貴州人和", OddStake = "半球", Guest = "水原三星", Prefer = "水原三星", Odds = 0.940f, Result = "2-2", PreferResult = (PreferResult)converter.ConvertBack("赢盘", typeof(PreferResult), null, null), Time2 = "04-30 15:59", Person = "庄家倒霉了" });
        }

        private void InitTopPerson()
        {
            _topPerson = new ObservableCollection<Person>();
            _topPerson.Add(new Person() { Name = "无聊玩玩", Profit = 11.5f, Total = 25, Win = 14, WinHalf = 5, Lose = 5, LoseHalf = 0, Draw = 1 });
            _topPerson.Add(new Person() { Name = "多伦多猛龙", Profit = 11f, Total = 27, Win = 16, WinHalf = 3, Lose = 6, LoseHalf = 1, Draw = 1 });
            _topPerson.Add(new Person() { Name = "纽约火焰", Profit = 11f, Total = 24, Win = 14, WinHalf = 4, Lose = 5, LoseHalf = 0, Draw = 1 });
            _topPerson.Add(new Person() { Name = "财爷win888", Profit = 10.5f, Total = 28, Win = 18, WinHalf = 0, Lose = 7, LoseHalf = 1, Draw = 2 });
            _topPerson.Add(new Person() { Name = "重在参与", Profit = 10f, Total = 28, Win = 16, WinHalf = 2, Lose = 7, LoseHalf = 0, Draw = 3 });
            _topPerson.Add(new Person() { Name = "天巧星燕青", Profit = 10f, Total = 24, Win = 14, WinHalf = 4, Lose = 6, LoseHalf = 0, Draw = 0 });
            _topPerson.Add(new Person() { Name = "喜龙泪", Profit = 9f, Total = 26, Win = 11, WinHalf = 6, Lose = 4, LoseHalf = 2, Draw = 3 });
            _topPerson.Add(new Person() { Name = "重新来过", Profit = 9f, Total = 26, Win = 15, WinHalf = 2, Lose = 7, LoseHalf = 0, Draw = 2 });
            _topPerson.Add(new Person() { Name = "球王之王", Profit = 8.5f, Total = 29, Win = 15, WinHalf = 4, Lose = 8, LoseHalf = 1, Draw = 0 });
            _topPerson.Add(new Person() { Name = "剑岛", Profit = 8.5f, Total = 24, Win = 14, WinHalf = 3, Lose = 7, LoseHalf = 0, Draw = 0 });
            _topPerson.Add(new Person() { Name = "茶居", Profit = 8f, Total = 32, Win = 19, WinHalf = 0, Lose = 11, LoseHalf = 0, Draw = 2 });
            _topPerson.Add(new Person() { Name = "哥是杯清茶", Profit = 8f, Total = 28, Win = 16, WinHalf = 2, Lose = 8, LoseHalf = 2, Draw = 0 });
            _topPerson.Add(new Person() { Name = "足球擂台", Profit = 7.5f, Total = 29, Win = 16, WinHalf = 1, Lose = 7, LoseHalf = 4, Draw = 1 });
            _topPerson.Add(new Person() { Name = "余韵犹在", Profit = 7.5f, Total = 26, Win = 13, WinHalf = 3, Lose = 7, LoseHalf = 0, Draw = 3 });
            _topPerson.Add(new Person() { Name = "十万火急", Profit = 7.5f, Total = 23, Win = 14, WinHalf = 0, Lose = 6, LoseHalf = 1, Draw = 2 });
            _topPerson.Add(new Person() { Name = "凤凰谷", Profit = 7.5f, Total = 22, Win = 12, WinHalf = 3, Lose = 5, LoseHalf = 2, Draw = 0 });
            _topPerson.Add(new Person() { Name = "重在娱乐", Profit = 7f, Total = 28, Win = 15, WinHalf = 3, Lose = 9, LoseHalf = 1, Draw = 0 });
            _topPerson.Add(new Person() { Name = "红红火火", Profit = 7f, Total = 26, Win = 15, WinHalf = 2, Lose = 9, LoseHalf = 0, Draw = 0 });
            _topPerson.Add(new Person() { Name = "竹叶青", Profit = 6.5f, Total = 31, Win = 17, WinHalf = 1, Lose = 10, LoseHalf = 2, Draw = 1 });
            _topPerson.Add(new Person() { Name = "火車頭", Profit = 6.5f, Total = 26, Win = 13, WinHalf = 2, Lose = 7, LoseHalf = 1, Draw = 3 });
        }

        private void InitTopYieldRoiPerson()
        {
            _topYieldRoiPerson = new ObservableCollection<YieldRoiPerson>();
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (o, e) =>
            {
                Random ran = new Random(0);
                foreach (var i in TopPersonProvider.Instance.PreferMost)
                {
                    Action action = () => { _topYieldRoiPerson.Add(YieldRoiProvider.Instance.GetPerson(i)); };
                    action.RunOnUI();
                }
            };
            bw.RunWorkerAsync();
        }
    }
}
