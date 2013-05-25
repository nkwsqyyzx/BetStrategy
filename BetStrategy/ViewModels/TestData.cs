using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetStrategy.ViewModels
{
    public static class TestData
    {
        #region GAME_SHOW_HTML
        public static string GAME_SHOW_HTML = @"
<script src=""inc/global.js""></script>

<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"">
<head>
<meta http-equiv=""Content-Type"" content=""text/html; charset=gb2312"">
<meta http-equiv=""X-UA-Compatible"" content=""IE=7"" />
<title>擂台参赛记录</title>
<link href=""skin/321800.css"" rel=""stylesheet"" type=""text/css"" />
</HEAD>
<BODY>

<br />
<div align=""center""><h2><font color=""#cc0000"">每日擂台参赛表</font></h2><a href=""game_top.asp"" target=""_blank""><span style=""color:#660000;""><strong>(擂台排行榜)</strong></span></a></div>
<table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""1"" bgcolor=""#0000a5"" class=""menu"">
  <tr>
    <td height=""22"" align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">擂台期数</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">所属赛事</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">开赛时间</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">主场球队</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#F00; font-size:14px"">盘口</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">客场球队</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">推荐</font>/<font color=""#FF0000"">水位</font></td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">比分</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">结果</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">发布时间</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">发表用户</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-02 08:50</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小保加</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥連泰斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:52</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">余韵犹在</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代/0.930</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:49</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">地狱黑仔王</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小兵突击</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">孟通</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3/3.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浦和紅鑽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:43</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">凤凰城的不死鸟</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-02 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">拜仁慕尼黑</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:34</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">斌少</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:32</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小花</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:32</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿根廷</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#44696D"" style=""color:#fff; font-size:14px"">波蘭乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 23:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">馬特斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">納斯薩</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.920</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:32</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">一场成名</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-02 06:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">甘美奧</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">聖塔菲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">聖塔菲/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:31</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">木棉树</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:29</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">我行我素</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:20</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">火流星</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#004488"" style=""color:#fff; font-size:14px"">瑞典盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">奧斯達</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">受平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">IFK哥德堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">奧斯達/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:10</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">歡樂今宵</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 23:59</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">里科威亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊地法格</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊地法格/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:07</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">空山新雨</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#666666"" style=""color:#fff; font-size:14px"">挪威盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 22:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">歐倫薩可</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3/3.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">特羅姆瑟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.870</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">墨斗红云</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">风林</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#79A836"" style=""color:#fff; font-size:14px"">德東北聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">特拉諾夫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格賴夫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">特拉諾夫/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:59</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小楼一夜听春雨</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:51</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">杨家渡风雨情</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">孟通</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">受球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浦和紅鑽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浦和紅鑽/0.980</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:34</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">罗纳尔多</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:29</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">super</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-02 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">拜仁慕尼黑</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:27</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">不孕不育专家</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">FC漢城</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布襦姆聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布襦姆聯/1.010</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:54</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">中奖太简单啦</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">FC漢城</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布襦姆聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">FC漢城/0.870</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:54</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">乌龙波</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#79A836"" style=""color:#fff; font-size:14px"">德東北聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">特拉諾夫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格賴夫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">特拉諾夫/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:53</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">辉煌先锋</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙台维加泰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.910</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:52</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">森林</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">昌原</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">金海</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:48</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">六月小</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江陵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/1.000</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">心情</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江陵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/1.000</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:44</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">bin-bin</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江陵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/1.000</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:44</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浪人心声</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:44</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zx01668</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江陵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:42</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">天巧星燕青</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江陵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:41</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">燕南天</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#B10000"" style=""color:#fff; font-size:14px"">韓國K</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">濟州聯隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶南FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">濟州聯隊/0.960</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:40</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">A乐乐</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-02 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">拜仁慕尼黑</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:39</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">Owen</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#B10000"" style=""color:#fff; font-size:14px"">韓國K</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">濟州聯隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶南FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶南FC/0.920</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:38</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lijian520</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#004488"" style=""color:#fff; font-size:14px"">瑞典盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">奧斯達</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">IFK哥德堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.920</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:25</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">怎么买都能中</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙台维加泰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:22</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">金牌出击</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-02 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">拜仁慕尼黑</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:20</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">qqzy</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江陵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:12</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">庄家倒霉了</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙台维加泰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.910</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:53</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lijin</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">孟通</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">受球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浦和紅鑽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">孟通/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:50</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">LXF1234</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙台维加泰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天/1.100</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">chilamian</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#666666"" style=""color:#fff; font-size:14px"">挪威盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 21:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">史托曼</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿爾塔</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">史托曼/0.930</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:28</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">飞黄腾达2</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#B10000"" style=""color:#fff; font-size:14px"">韓國K</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">濟州聯隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶南FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.940</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:17</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">上上签</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙台维加泰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.910</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:15</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">jack</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">FC漢城</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布襦姆聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布襦姆聯/1.010</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">一天一点赢</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#004488"" style=""color:#fff; font-size:14px"">瑞典盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">佐加頓斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">奧基迪</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">佐加頓斯/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 15:43</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">黄金一代</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#004488"" style=""color:#fff; font-size:14px"">瑞典盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">佐加頓斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">奧基迪</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">奧基迪/1.030</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 15:37</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">asd3388</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">瑞典U16(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5/3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">愛沙尼亞U16</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.880</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 15:31</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">足求胜果</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#D44580"" style=""color:#fff; font-size:14px"">德青北</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 17:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">基爾高士丁U19</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3/3.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡爾斯耶拿U19</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.990</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 15:02</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">wintion</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 15:01</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">澳门盘口</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 15:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">八月十日</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙台维加泰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.910</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:35</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">绿野仙踪</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 23:59</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">里科威亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊地法格</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊地法格/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:33</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">waley</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">FC漢城</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布襦姆聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.960</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:25</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">身不由己</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-02 08:50</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小保加</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平手</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥連泰斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥連泰斯/0.820</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:20</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">不学无术</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代/0.930</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:07</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">jaddeking</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江陵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蔚山造船/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:07</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">贝多芬</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 23:59</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">里科威亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊地法格</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊地法格/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:52</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">神算子</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">瑞典U16(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5/3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">愛沙尼亞U16</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.880</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:38</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">雪儿</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙台维加泰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:37</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">赢球偷着乐</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#004488"" style=""color:#fff; font-size:14px"">瑞典盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">奧斯達</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">受平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">IFK哥德堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">IFK哥德堡/0.930</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:35</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">冷云</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#B10000"" style=""color:#fff; font-size:14px"">韓國K</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">濟州聯隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶南FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶南FC/0.920</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:31</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">星星点灯</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">FC漢城</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布襦姆聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">FC漢城/0.870</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:28</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">爱雨浪漫</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#79A836"" style=""color:#fff; font-size:14px"">德東北聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">特拉諾夫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格賴夫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">特拉諾夫/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:26</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">易胜博</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代/0.930</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:24</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浪子668</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶州KHNP</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">龍仁市FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:19</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">中奖</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CC00"" style=""color:#fff; font-size:14px"">日職丙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡馬塔馬爾贊岐</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">琉球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/1.060</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:18</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">泰然处之</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶州KHNP</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">龍仁市FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/1.000</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">飞天神猪</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙台维加泰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">江蘇舜天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大头</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 16:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">瑞典U16(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5/3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">愛沙尼亞U16</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.880</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 13:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lili369</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CC00"" style=""color:#fff; font-size:14px"">日職丙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">長野琶扼摟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">橫河武藏野FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:59</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">明明白白</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#B10000"" style=""color:#fff; font-size:14px"">韓國K</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">濟州聯隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶南FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">濟州聯隊/0.960</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:48</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">轻轻巧巧</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CC00"" style=""color:#fff; font-size:14px"">日職丙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">長野琶扼摟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">橫河武藏野FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:36</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球下盘</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">昌原</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">金海</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:33</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">金宝博玉女吧总代理</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:14</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">谷雨</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">孟通</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3/3.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浦和紅鑽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:11</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">张三丰</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">FC漢城</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布襦姆聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3000元</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CC00"" style=""color:#fff; font-size:14px"">日職丙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">本田FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">MIO琵琶湖滋賀</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">MIO琵琶湖滋賀/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:13</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">摩云金翅麒麟</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CC00"" style=""color:#fff; font-size:14px"">日職丙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">福島聯隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大分公式</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大分公式/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:10</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">逆天狂</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CC00"" style=""color:#fff; font-size:14px"">日職丙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">福島聯隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大分公式</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:07</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">八神花露水</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 20:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">廣州恆大</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">全北現代/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:06</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大渊八卦掌</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CC00"" style=""color:#fff; font-size:14px"">日職丙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">町田澤維亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">藤枝MYFC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">丰山绝技</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 14:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶州KHNP</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">龍仁市FC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:04</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">godball</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CC00"" style=""color:#fff; font-size:14px"">日職丙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 12:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">日立槴木</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">秋田藍色閃電</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">-</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#0000FF"">等待</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:03</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">终极梦想</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">提華納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭美拉斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">提華納/1.000</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:01</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">爱雨浪漫</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">提華納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭美拉斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭美拉斯/0.920</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 08:53</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">歡樂今宵</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">提華納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭美拉斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭美拉斯/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 07:26</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">wqu003</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#DB1000"" style=""color:#fff; font-size:14px"">秘魯春</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 07:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">聖馬丁(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡加馬卡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡加馬卡/0.970</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 04:46</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">圣婴</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">提華納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭美拉斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭美拉斯/1.020</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 04:09</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">天啊</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#DB1000"" style=""color:#fff; font-size:14px"">秘魯春</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 07:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">聖馬丁(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡加馬卡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">聖馬丁(中)/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 03:20</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">战无不胜</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 09:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">提華納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭美拉斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">提華納/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:29</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小头</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#cc3300"" style=""color:#fff; font-size:14px"">英冠</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">米禾爾</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">受平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">水晶宮</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">水晶宮/1.060</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 01:56</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">杀庄一秒</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">皇家馬德里</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">多特蒙德</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 01:53</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">足求胜果</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">皇家馬德里</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球/球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">多特蒙德</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">多特蒙德/0.870</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 01:50</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">足球老青年</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#778800"" style=""color:#fff; font-size:14px"">蘇青聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">喜百年U20</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5/4球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">登地U20</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 01:40</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">咖啡病毒</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F90000"" style=""color:#fff; font-size:14px"">英U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿森納U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">狼隊U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿森納U21/1.040</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#006600"">走水</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 01:18</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">民哥也疯狂</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿爾艾利吉達(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">納薩SC</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">納薩SC/0.970</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 01:16</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">ycdy</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#cc3300"" style=""color:#fff; font-size:14px"">英冠</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">米禾爾</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平手</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">水晶宮</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">米禾爾/1.100</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#006600"">走水</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 01:06</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">流风</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">皇家馬德里</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球/球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">多特蒙德</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">多特蒙德/0.930</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 00:58</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">mozaozi</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#DB1000"" style=""color:#fff; font-size:14px"">秘魯春</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 07:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">聖馬丁(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡加馬卡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/1.020</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-01 00:54</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">广东梁朝伟</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" colspan=""11"" align=""center"" bgcolor=""#FFFFFF""><div class=""tzpage"">当前页次：1 / 364 共 364 页 共 36385 条 每页显示100条
 [首页] [上一页] <a href=""Game_Show.asp?page=2"">[下一页]</a> <a href=""Game_Show.asp?page=364"">[尾页]</a></div></td>
  </tr>
</table>
<br />

</body></HTML>


";
        #endregion
        #region GAME_TOP HTML
        public static string GAME_HTML_TOP = @"
<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"">
<script src=""inc/global.js""></script>

<head>
<meta http-equiv=""Content-Type"" content=""text/html; charset=gb2312"" />
<title>擂台排行榜 - 玉女心经足球吧</title>
<link href=""skin/321800.css"" rel=""stylesheet"" type=""text/css"">
</head>
<body>

<br />
<div align=""center""><h2><font color=""#CC0000"">《█4月第46届“88娱乐城”杯足球精英擂台赛跟帖处█ 排行榜》</font></h2></div>
<table width=""900"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""1"" bgcolor=""#0000a5"" class=""menu"">
  <tr>
    <td height=""30"" colspan=""10"" align=""center"" background=""skin/3.gif"" style="" color:#0000D5; font-size:14px"">排行标准:净胜场数多者排前;如净胜场次相同者,有效推荐场次多(走盘不计)排前(<font color=""#FF0000"">全赢算1 赢半算0.5 全输算-1 输半算-0.5 走水算0</font>)</td>
  </tr>
  <tr>
    <td height=""22"" align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">排名</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">会员名称</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#F00; font-size:14px"">净胜</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">总发布</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">全赢</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">赢半</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">全输</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">输半</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">走水</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#FF0000; font-size:14px"">擂台记录</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第1名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">章鱼帝</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=章鱼帝"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第2名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">绿野仙踪</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">9.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=绿野仙踪"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第3名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿根廷</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">9.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=阿根廷"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第4名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lili369</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lili369"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第5名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿麦的理想</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=阿麦的理想"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第6名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">西班牙王子</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">8.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=西班牙王子"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第7名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">jaddeking</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">8.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=jaddeking"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第8名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">马勒当拿</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">8.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=马勒当拿"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第9名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">绿茵红魔</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=绿茵红魔"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第10名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">asd3388</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=asd3388"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第11名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">Owen</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=Owen"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第12名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大D哥</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=大D哥"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第13名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">不学无术</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">7.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=不学无术"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第14名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">爱雨浪漫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">22场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=爱雨浪漫"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第15名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">jack</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=jack"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第16名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">纽约红牛</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=纽约红牛"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第17名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">茎候佳阴</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=茎候佳阴"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第18名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">谷雨</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">6.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=谷雨"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第19名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lxs529</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">6.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lxs529"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第20名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">星星点灯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">20场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=星星点灯"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第21名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">打救</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=打救"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第22名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">辉煌先锋</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=辉煌先锋"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第23名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">sweetcat</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=sweetcat"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第24名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">ahao520</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=ahao520"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第25名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">明明白白</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=明明白白"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第26名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">木棉树</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=木棉树"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第27名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">余韵犹在</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=余韵犹在"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第28名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">身不由己</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=身不由己"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第29名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">天巧星燕青</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=天巧星燕青"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第30名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">神算子</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=神算子"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第31名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">空山新雨</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">19场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=空山新雨"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第32名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">春游记</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=春游记"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第33名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">明年今日</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=明年今日"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第34名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">好給力</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=好給力"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第35名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1300100915</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=1300100915"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第36名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">ycdy</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=ycdy"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第37名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">飞天神猪</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">20场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=飞天神猪"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第38名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">人在美洲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">19场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=人在美洲"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第39名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">segespa</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=segespa"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第40名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">无聊玩玩</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=无聊玩玩"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第41名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">九月九的酒</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=九月九的酒"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">sos73</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=sos73"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">林</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=林"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第44名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">钱龙大帝</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=钱龙大帝"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">民哥也疯狂</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=民哥也疯狂"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">重在参与</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=重在参与"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">流风</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=流风"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第48名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">落日之使</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=落日之使"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第49名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">回心融雪衣</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=回心融雪衣"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第50名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">残酷游戏</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=残酷游戏"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第51名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小楼一夜听春雨</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小楼一夜听春雨"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第52名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">会同甲天下</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=会同甲天下"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第53名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3000元</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=3000元"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第54名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">xytlove</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=xytlove"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第55名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">轻轻巧巧</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=轻轻巧巧"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第56名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">高原</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=高原"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第57名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">独卧云台</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=独卧云台"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第58名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">圣路易斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=圣路易斯"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第59名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">咖啡病毒</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=咖啡病毒"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第60名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">提子味</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=提子味"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第61名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">老刘</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=老刘"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第62名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">chilamian</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=chilamian"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第63名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大头</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">19场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=大头"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第64名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">茶居</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=茶居"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第65名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">庄家倒霉了</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=庄家倒霉了"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第66名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">凤凰谷</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=凤凰谷"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第67名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">神一样的玩家</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=神一样的玩家"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第68名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">yuess</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=yuess"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第69名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">香鸡脚</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=香鸡脚"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第70名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">十万火急</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=十万火急"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第71名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">海里昙花</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=海里昙花"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第72名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">麦卡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=麦卡"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第73名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">Y三</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=Y三"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第74名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">五大联赛</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=五大联赛"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第75名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">中华V大师</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=中华V大师"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第76名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">专业大球推荐</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=专业大球推荐"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第77名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">歡樂今宵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=歡樂今宵"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第78名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浪子668</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=浪子668"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第79名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lijin</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lijin"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第80名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">澳门盘口</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=澳门盘口"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第81名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">普通老百姓</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=普通老百姓"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第82名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">黄金一代</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=黄金一代"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第83名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">mzzzzzzm</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=mzzzzzzm"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第84名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">浪人心声</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=浪人心声"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第85名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">bin-bin</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=bin-bin"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第86名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">怎么买都能中</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=怎么买都能中"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第87名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">心情</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=心情"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第88名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">暗杠发财</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=暗杠发财"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第89名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">一天一点赢</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=一天一点赢"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第90名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">力霸天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=力霸天"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第91名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">p2f2003</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=p2f2003"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第92名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">地狱黑仔王</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=地狱黑仔王"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第93名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小布宝贝</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小布宝贝"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第94名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">张三丰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=张三丰"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第95名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">开心赢小钱</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=开心赢小钱"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第96名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">super</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=super"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第97名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">dfyj1111</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=dfyj1111"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第98名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">顺水顺风</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=顺水顺风"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第99名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">水舞传</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=水舞传"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第100名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">红酒</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=红酒"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第101名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">水龙头</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=水龙头"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第102名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">帅的躲家里</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=帅的躲家里"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第103名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">H7N9</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=H7N9"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第104名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小青</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小青"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第105名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">一场成名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=一场成名"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第106名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伤女王</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=伤女王"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第107名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">金牌出击</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=金牌出击"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第108名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">963118818</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=963118818"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第109名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">无肛大师</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=无肛大师"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第110名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">风中独步</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=风中独步"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第111名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zhang</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zhang"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第112名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">火流星</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=火流星"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第113名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">广东梁朝伟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=广东梁朝伟"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第114名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">夏天狂暴</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=夏天狂暴"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第115名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">你是我的最爱</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=你是我的最爱"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第116名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">高尔夫球场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=高尔夫球场"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第117名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">残月</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=残月"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第118名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">不死鸟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=不死鸟"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第119名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">童年</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=童年"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第120名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">生存</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=生存"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第121名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12315</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=12315"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第122名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小头</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小头"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第123名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">wqu003</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=wqu003"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第124名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">墨斗红云</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=墨斗红云"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第125名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">iq</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=iq"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第126名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">红红火火</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=红红火火"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第127名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">凤凰城的不死鸟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=凤凰城的不死鸟"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第128名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">北风呼啸</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=北风呼啸"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第129名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lzzw0076</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lzzw0076"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第130名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">mozaozi</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=mozaozi"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第131名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">天之骄子</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=天之骄子"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第132名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿拉伯建筑商</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=阿拉伯建筑商"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第133名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">印加帝国</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=印加帝国"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第134名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">老油条</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=老油条"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第135名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">doxx</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=doxx"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第136名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">剑岛</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=剑岛"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第137名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">捕捉屏幕</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=捕捉屏幕"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第138名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">赢钱护失足</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=赢钱护失足"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第139名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">终极梦想</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=终极梦想"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第140名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">┽深水老骨鱼</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=┽深水老骨鱼"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第141名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">laughing哥</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=laughing哥"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第142名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">财爷win888</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=财爷win888"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第143名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">godball</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=godball"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第144名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">湛江凌</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=湛江凌"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第145名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zhongti</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zhongti"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第146名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">奶嘴锋</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=奶嘴锋"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第147名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">烟花易冷</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=烟花易冷"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第148名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">风靡全球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=风靡全球"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第149名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">苦楝鸟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=苦楝鸟"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第150名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">johncmg</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=johncmg"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第151名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">rmb6688</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=rmb6688"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第152名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">W先生</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=W先生"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第153名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">芮萱</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=芮萱"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第154名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">jason</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=jason"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第155名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">最真最全</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=最真最全"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第156名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">雪儿</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">19场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=雪儿"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第157名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">低调的高富帅</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">19场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=低调的高富帅"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第158名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">一飞冲天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=一飞冲天"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第159名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">新加坡武裝部隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=新加坡武裝部隊"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第160名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">无冕之王</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=无冕之王"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第161名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">斌少</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=斌少"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第162名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12388123</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=12388123"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第163名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">运达不来霉</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=运达不来霉"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第164名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">爷有旺仔</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=爷有旺仔"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第165名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">朝鲜核武器</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=朝鲜核武器"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第166名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">笑妹</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=笑妹"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第167名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">不孕不育专家</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=不孕不育专家"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第168名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">马小姐也疯狂</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=马小姐也疯狂"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第169名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">挑战者</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=挑战者"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第170名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">丰山绝技</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=丰山绝技"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第171名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大渊八卦掌</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=大渊八卦掌"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第172名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">八神花露水</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=八神花露水"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第173名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">西更天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=西更天"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第174名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">逆天狂</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=逆天狂"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第175名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">美女</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=美女"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第176名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">q119110</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=q119110"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第177名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">摩云金翅麒麟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=摩云金翅麒麟"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第178名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">wrim</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=wrim"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第179名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">rose</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=rose"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第180名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">球倾天下</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=球倾天下"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第181名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">等待多戈</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=等待多戈"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第182名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lhlianxin</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lhlianxin"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第183名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">燕赤霞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=燕赤霞"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第184名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">上上签</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=上上签"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第185名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">中国博球盟主</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=中国博球盟主"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第186名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">赢球偷着乐</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=赢球偷着乐"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第187名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">凤凰传奇</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=凤凰传奇"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第188名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">崛起</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=崛起"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第189名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">默默非金</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=默默非金"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第190名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小红帽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小红帽"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第191名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">老鬼看盘</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=老鬼看盘"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第192名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">梦陀人</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=梦陀人"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第193名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">高级绘图</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=高级绘图"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第194名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">热血青年</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=热血青年"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第195名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">农夫果园</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=农夫果园"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第196名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大杀四方</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=大杀四方"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第197名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">庄见晕</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=庄见晕"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第198名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">虎年福运</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=虎年福运"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第199名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=格力电器"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第200名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">风林</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=风林"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第201名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">球盘杀手</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=球盘杀手"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第202名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">杨家渡风雨情</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=杨家渡风雨情"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第203名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">飞黄腾达2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=飞黄腾达2"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第204名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥是杯清茶</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=哥是杯清茶"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第205名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">一叶扁舟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=一叶扁舟"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第206名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">半球生死</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=半球生死"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第207名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">goals</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=goals"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第208名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">不懂球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=不懂球"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第209名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">山人</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=山人"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第210名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">难得糊涂</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=难得糊涂"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第211名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">riri</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=riri"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第212名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">学习中</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=学习中"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第213名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">^_^主公^_^</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=^_^主公^_^"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第214名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">xjh168</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=xjh168"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第215名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">听风者</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=听风者"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第216名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">假盘高手</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=假盘高手"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第217名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">神马都是浮云</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=神马都是浮云"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第218名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">aqac</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=aqac"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第219名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">我爱2K</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=我爱2K"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第220名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">陈冠希</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=陈冠希"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第221名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">去他个球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=去他个球"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第222名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lrb1618</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lrb1618"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第223名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">Y哥</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=Y哥"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第224名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小花</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小花"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第225名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">球该怎么进</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=球该怎么进"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第226名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">中奖太简单啦</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=中奖太简单啦"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第227名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">圣婴</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=圣婴"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第228名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">yuelao200</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=yuelao200"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第229名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">六月小</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=六月小"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第230名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">燕南天</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=燕南天"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第231名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">稳赢专家</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=稳赢专家"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第232名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">柱囝</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=柱囝"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第233名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">心有不甘</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=心有不甘"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第234名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">hongfa888</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=hongfa888"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第235名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">A乐乐</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=A乐乐"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第236名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">取之不尽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=取之不尽"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第237名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">虎虎生威</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=虎虎生威"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第238名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">bwin24</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=bwin24"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第239名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">萧十一郎</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=萧十一郎"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第240名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">放弃是美</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=放弃是美"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第241名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小米</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小米"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第242名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zxy60120</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zxy60120"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第243名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">huajia</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=huajia"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第244名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">杀庄一秒</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=杀庄一秒"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第245名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">强势出击</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=强势出击"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第246名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">long597465612</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=long597465612"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第247名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">yong200251</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=yong200251"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第248名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">杀出个黎明</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=杀出个黎明"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第249名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zx01668</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zx01668"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第250名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">乌龙波</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=乌龙波"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第251名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球下盘</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小球下盘"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第252名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">霸王龙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=霸王龙"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第253名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">我行我素</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=我行我素"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第254名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">红日</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=红日"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第255名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">弹弓六</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=弹弓六"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第256名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">东航空乘</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=东航空乘"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第257名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">长工七号</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=长工七号"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第258名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">王成良</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=王成良"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第259名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">事事為王</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=事事為王"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第260名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0度心凉</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=0度心凉"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第261名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lijian520</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lijian520"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第262名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">月影神鹰</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=月影神鹰"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第263名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">动听的乐章</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=动听的乐章"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第264名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">leehom</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=leehom"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第265名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">生为足球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=生为足球"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第266名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">maitaohua</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=maitaohua"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第267名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">89838399</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=89838399"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第268名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">kitty杨</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=kitty杨"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第269名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">强人</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=强人"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第270名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">青年的鬼</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=青年的鬼"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第271名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">中场换人</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=中场换人"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第272名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">西班牙劲啊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=西班牙劲啊"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第273名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lanquan11</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lanquan11"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第274名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">yjwxf</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=yjwxf"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第275名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">xby112</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=xby112"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第276名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">寅虎</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=寅虎"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第277名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">bobo</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=bobo"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第278名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lw8088</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lw8088"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第279名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">txzl</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=txzl"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第280名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">仙人指路</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=仙人指路"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第281名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">wcnm</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=wcnm"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第282名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蜘蛛侠</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=蜘蛛侠"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第283名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">展翅高飞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=展翅高飞"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第284名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">txdy</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=txdy"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第285名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">chen</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=chen"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第286名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">pois</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=pois"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第287名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大赌伤身</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=大赌伤身"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第288名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">Goal</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=Goal"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第289名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小俊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小俊"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第290名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">球球250881595</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=球球250881595"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第291名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">托马斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=托马斯"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第292名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">率赢</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=率赢"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第293名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">靖超超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=靖超超"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第294名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zuqiu</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zuqiu"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第295名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">二少</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=二少"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第296名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">yhbbs</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=yhbbs"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第297名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">活在当下</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=活在当下"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第298名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">列壳车</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=列壳车"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第299名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">banma</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=banma"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第300名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">重新来过</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=重新来过"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第301名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">专搞下盘</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=专搞下盘"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第302名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">长远利益</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=长远利益"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第303名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">金左脚</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=金左脚"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第304名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">ainicp1314</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=ainicp1314"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第305名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">炮哥</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=炮哥"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第306名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">职业玩家</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=职业玩家"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第307名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">connor</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=connor"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第308名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">dong258</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=dong258"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第309名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">gxfc</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=gxfc"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第310名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">踩到牛屎</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=踩到牛屎"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第311名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">kingmak</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=kingmak"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第312名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zhongle</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zhongle"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第313名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">最爱皇马</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=最爱皇马"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第314名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第一战</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=第一战"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第315名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">博命汉</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=博命汉"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第316名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">百戰百勝</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=百戰百勝"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第317名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">我爱法拉利</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=我爱法拉利"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第318名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">ells</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=ells"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第319名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">盈利世界</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=盈利世界"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第320名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">诸葛神亮</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=诸葛神亮"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第321名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">mao18</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=mao18"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第322名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">xiada</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=xiada"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第323名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">赢球专家</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=赢球专家"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第324名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zqcp</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zqcp"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第325名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">sdgr</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=sdgr"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第326名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">贝多芬</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=贝多芬"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第327名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">东北球王</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=东北球王"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第328名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">godkiller</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=godkiller"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第329名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">海阔天空2013</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=海阔天空2013"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第330名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">上下摆风</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=上下摆风"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第331名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿汉</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=阿汉"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第332名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">逍遥残剑</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=逍遥残剑"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第333名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">我型我show</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=我型我show"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第334名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">黑客的态度</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=黑客的态度"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第335名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">地火缘铁鞋</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=地火缘铁鞋"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第336名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">无极旋风</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=无极旋风"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第337名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">龙泉之吻</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=龙泉之吻"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第338名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">启蒙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=启蒙"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第339名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">朱鹏锦</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=朱鹏锦"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第340名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">樱木花道</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=樱木花道"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第341名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">飞天戟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=飞天戟"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第342名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">低调的人</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=低调的人"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第343名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">只有再拼</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=只有再拼"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第344名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小人华BD</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小人华BD"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第345名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">holdykwan</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=holdykwan"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第346名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">世界第一操盘手</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=世界第一操盘手"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第347名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">亮剑</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-1.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=亮剑"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第348名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">为梦等你</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=为梦等你"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第349名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">足球老青年</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=足球老青年"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第350名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lxf1234</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lxf1234"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第351名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">古惑仔</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=古惑仔"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第352名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">跳舞草</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=跳舞草"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第353名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">柑蕉桔梨萝柚</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=柑蕉桔梨萝柚"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第354名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">兰帕德</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=兰帕德"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第355名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">爱在西元后</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=爱在西元后"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第356名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">葡萄牙先锋</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=葡萄牙先锋"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第357名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">菠菜大胜</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=菠菜大胜"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第358名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小李飞刀</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小李飞刀"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第359名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">366888</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=366888"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第360名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">穿越尘世的承诺</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=穿越尘世的承诺"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第361名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">面包果</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=面包果"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第362名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">汶川寻梦</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=汶川寻梦"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第363名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">忠诚度分析</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=忠诚度分析"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第364名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">独角刺龙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=独角刺龙"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第365名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">何济公</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=何济公"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第366名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">不是传说</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=不是传说"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第367名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">帮主</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=帮主"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第368名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">夜未眠</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=夜未眠"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第369名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">真人大小钱</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=真人大小钱"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第370名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">红蜻蜓</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=红蜻蜓"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第371名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">幸福死了</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=幸福死了"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第372名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">雁荡山洗刀</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=雁荡山洗刀"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第373名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">(_刀锋日玫瑰-猎狐在流泪</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=(_刀锋日玫瑰-猎狐在流泪"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第374名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">胖子</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=胖子"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第375名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">TJ缘</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=TJ缘"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第376名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">风清扬</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=风清扬"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第377名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">疯狂玩球十余年</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=疯狂玩球十余年"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第378名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">只为三餐温饱</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=只为三餐温饱"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第379名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zyqld</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zyqld"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第380名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">逸逸有欲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=逸逸有欲"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第381名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">红中</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=红中"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第382名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥是一把刀</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=哥是一把刀"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第383名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">islys</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=islys"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第384名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">师傅交代说名字要够长这样才够叼</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=师傅交代说名字要够长这样才够叼"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第385名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">点球成金</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=点球成金"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第386名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">马前炮</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=马前炮"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第387名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">鬼鬼1991</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=鬼鬼1991"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第388名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">90分钟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=90分钟"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第389名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">国枫888</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=国枫888"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第390名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">cxm383</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=cxm383"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第391名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">积木</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=积木"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第392名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">公爵王</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=公爵王"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第393名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">球王之王</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=球王之王"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第394名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">泰国本田</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=泰国本田"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第395名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">嫒欣觉罗</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=嫒欣觉罗"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第396名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">救世主</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=救世主"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第397名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">背水一战</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=背水一战"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第398名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">BUICKfifa</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=BUICKfifa"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第399名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">又赌又嫖</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=又赌又嫖"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第400名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">神兵</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=神兵"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第401名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">ronapigu</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=ronapigu"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第402名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">四大名捕</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=四大名捕"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第403名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">我是低手A</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-2.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=我是低手A"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第404名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">shl2012</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=shl2012"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第405名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">天啊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=天啊"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第406名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">瑪莉皇后2號郵輪</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=瑪莉皇后2號郵輪"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第407名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">中奖</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=中奖"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第408名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">wintion</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=wintion"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第409名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">udchina999</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=udchina999"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第410名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">足求胜果</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=足求胜果"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第411名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">胜哥</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=胜哥"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第412名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">板烧鸡腿堡仅售12蚊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=板烧鸡腿堡仅售12蚊"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第413名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">NO.1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=NO.1"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第414名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">一球领先</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=一球领先"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第415名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">波子</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=波子"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第416名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zbjsmg</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zbjsmg"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第417名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">龙8啤酒</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=龙8啤酒"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第418名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿一足球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=阿一足球"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第419名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">se7en</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=se7en"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第420名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6人足球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=6人足球"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第421名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">冷云</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=冷云"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第422名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">梅西的左脚</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">13场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=梅西的左脚"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第423名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">Klaus</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=Klaus"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第424名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">红到让你信</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=红到让你信"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第425名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">杀手47</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=杀手47"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第426名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">竹叶青</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=竹叶青"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第427名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">希望之星</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=希望之星"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第428名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">长兴岛</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=长兴岛"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第429名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彩世界花园</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=彩世界花园"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第430名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">湘中天龙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=湘中天龙"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第431名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">名花有主</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=名花有主"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第432名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">75683672</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=75683672"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第433名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">鄙视天华</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-3.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=鄙视天华"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第434名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">八月十日</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=八月十日"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第435名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">下盘王</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=下盘王"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第436名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">易胜博</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=易胜博"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第437名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">云里金刚虎</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=云里金刚虎"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第438名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">风之子归来</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=风之子归来"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第439名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">橘子小平</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=橘子小平"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第440名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">国税局</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=国税局"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第441名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大只蚁</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=大只蚁"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第442名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">锐壮壮</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=锐壮壮"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第443名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">waley</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=waley"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第444名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">战无不胜</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=战无不胜"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第445名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">95988</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=95988"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第446名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zy530</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zy530"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第447名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">扇影舞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-4.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=扇影舞"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第448名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慢慢来</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">17场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=慢慢来"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第449名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">罗纳尔多</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=罗纳尔多"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第450名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">爽爽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=爽爽"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第451名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">重在娱乐</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=重在娱乐"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第452名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">lk930</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">8场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=lk930"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第453名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">金宝博玉女吧总代理</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=金宝博玉女吧总代理"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第454名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">路人甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-5.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=路人甲"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第455名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">森林</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">16场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=森林"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第456名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">qqzy</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">15场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=qqzy"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第457名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">长虹贯日</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=长虹贯日"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第458名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">鱼肝油</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-6场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=鱼肝油"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第459名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">zzbb3344</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-6.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">9场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=zzbb3344"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第460名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">足球冠军</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">19场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=足球冠军"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第461名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">泰然处之</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-7场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">18场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=泰然处之"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第462名</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小兵突击</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">-7.5场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">14场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0场</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">
    <a href=""Game_User.asp?id=小兵突击"" target=""_blank""><font color=""#FF0000"">参赛记录</font></a></td>
  </tr>
</table>


</body>
</html>";
        #endregion
        #region GAME_USER
        public static string GAME_USER_HTML = @"
<script src=""inc/global.js""></script>
<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"">
<head>
<meta http-equiv=""Content-Type"" content=""text/html; charset=gb2312"">
<meta http-equiv=""X-UA-Compatible"" content=""IE=7"" />
<title>的擂台参赛记录</title>
<link href=""skin/321800.css"" rel=""stylesheet"" type=""text/css"" />
</HEAD>
<BODY>

<br />
<div align=""center""><h2><font color=""#CC0000"">《格力电器》擂台参赛记录</font></h2></div>
<table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""1"" bgcolor=""#0000a5"" class=""menu"">
  <tr>
    <td height=""22"" align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">擂台期数</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">所属赛事</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">开赛时间</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">主场球队</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#F00; font-size:14px"">盘口</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">客场球队</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">推荐</font>/<font color=""#FF0000"">水位</font></td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">比分</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">结果</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">发布时间</td>
    <td align=""center"" background=""skin/88.gif"" style=""color:#0000D5; font-size:14px"">发表用户</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#6F6161"" style=""color:#fff; font-size:14px"">法乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-25 02:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡昂</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">一球/球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">GFC阿些斯奧</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡昂/0.950</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-24 23:07</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#7D4000"" style=""color:#fff; font-size:14px"">土甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-23 23:59</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">馬尼沙斯堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿達納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿達納/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-23 21:28</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#004488"" style=""color:#fff; font-size:14px"">瑞典超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-24 01:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">艾夫斯堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布諾馬博亞納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">艾夫斯堡/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">6-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-23 09:48</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#2f3fd2"" style=""color:#fff; font-size:14px"">奧甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-23 02:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">華卡迪路</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平手</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格拉茨</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">華卡迪路/0.810</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-22 07:09</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#438E0B"" style=""color:#fff; font-size:14px"">西乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-21 03:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">CD瓜達拉哈拉</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">梅西亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">梅西亞/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-20 22:38</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#CC3399"" style=""color:#fff; font-size:14px"">德北聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-20 00:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">漢維德</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5/3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">吉奧利</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.860</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-19 21:15</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#666699"" style=""color:#fff; font-size:14px"">斯亞甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-18 23:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥里卡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">拖里格拉瓦</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-18 21:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#137AAC"" style=""color:#fff; font-size:14px"">芬超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-17 23:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">赫爾辛基</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">TPS杜古</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.970</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-17 17:36</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#666666"" style=""color:#fff; font-size:14px"">挪威超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-17 01:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">洛辛堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">薩普斯堡08</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.810</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-16 13:54</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#3366CC"" style=""color:#fff; font-size:14px"">南非甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-15 21:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">波羅克瓦尼城</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">非洲勇士</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-15 17:32</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第47期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-15 01:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">威登布拉克</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5/3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慕士達</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">05-14 22:09</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#F75000"" style=""color:#fff; font-size:14px"">歐冠盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-23 18:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">柏雷素爾</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">貴州人和</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.820</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-23 16:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#6E3D9D"" style=""color:#fff; font-size:14px"">俄甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-22 21:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彼特若堤斯特</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">沃爾加</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">沃爾加/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-22 19:29</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#33CCCC"" style=""color:#fff; font-size:14px"">意丙盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-21 22:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">安芝</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">莫斯科戴拿模</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3-3</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-21 21:34</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#990099"" style=""color:#fff; font-size:14px"">德甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-20 21:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">漢堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">杜塞爾多夫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-20 21:06</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#FF4EA6"" style=""color:#fff; font-size:14px"">荷乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-20 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿高斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">恩浩雲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-19 22:58</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-19 06:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">利伯泰德</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">堤格雷</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3-5</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-18 21:41</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#279A99"" style=""color:#fff; font-size:14px"">波青聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-17 17:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">列治亞青年隊U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">派雅斯特青年隊U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">列治亞青年隊U21/0.830</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">7-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-17 14:47</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#cc3300"" style=""color:#fff; font-size:14px"">英冠</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-17 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">米德爾斯堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">諾定咸森林</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.820</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-16 22:07</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#006633"" style=""color:#fff; font-size:14px"">西甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-16 03:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">馬略卡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">切爾達</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">切爾達/1.030</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-15 21:41</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第46期</td>
    <td align=""center"" bgcolor=""#660033"" style=""color:#fff; font-size:14px"">美職業</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-14 23:59</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">蒙特利爾衝擊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥倫布機員</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥倫布機員/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">04-14 22:29</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#3a794e"" style=""color:#fff; font-size:14px"">歐青U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-26 21:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">白俄羅斯U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">冰島U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-26 19:56</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#2CAF2C"" style=""color:#fff; font-size:14px"">日職乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-24 15:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">神戶勝利船</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">草津溫泉群馬</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.820</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-24 13:48</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#FF1010"" style=""color:#fff; font-size:14px"">韓聯盟</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-23 14:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">慶州KHNP</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">金海</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-23 13:29</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#266013"" style=""color:#fff; font-size:14px"">南美預選</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-23 08:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿根廷</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3/3.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">委內瑞拉</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-22 13:18</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#CCBB24"" style=""color:#fff; font-size:14px"">印尼甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-21 16:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">柏斯達突隆格恭</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">帕爾斯巴邦卡蘭</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-21 16:04</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#DDDD00"" style=""color:#fff; font-size:14px"">巴聖錦標</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-21 06:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">歐斯特</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伯拉根森</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">歐斯特/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-20 22:24</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#0076B1"" style=""color:#fff; font-size:14px"">意乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-20 03:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿斯科利</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">里賈納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.820</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-3</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-19 14:23</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#8C8A64"" style=""color:#fff; font-size:14px"">希臘超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-19 01:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">彭拉伊高斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">薩丁</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">薩丁/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-18 23:04</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#FF3333"" style=""color:#fff; font-size:14px"">英超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-17 23:59</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">切爾西</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">西漢姆</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-17 21:54</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#660033"" style=""color:#fff; font-size:14px"">美職業</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-17 00:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">紐約紅牛</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">華盛頓聯隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">華盛頓聯隊/0.830</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-16 22:41</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#D761B0"" style=""color:#fff; font-size:14px"">德丙聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-16 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">安達赫治</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">賽瑞貝肯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">賽瑞貝肯/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-15 21:38</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#660000"" style=""color:#fff; font-size:14px"">自由盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-15 08:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">聖喬希奧魯羅</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">米倫拿列奧</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.860</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-14 21:34</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#1D448B"" style=""color:#fff; font-size:14px"">意丙2A</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-13 21:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">瓦利歐斯特</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">亞歷山德利亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-13 19:01</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第45期</td>
    <td align=""center"" bgcolor=""#4756D8"" style=""color:#fff; font-size:14px"">奧乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-13 01:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第一維也納</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">路斯登洛</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.910</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">03-12 20:12</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第44期</td>
    <td align=""center"" bgcolor=""#6633CC"" style=""color:#fff; font-size:14px"">南聯盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">02-13 21:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">米拉諾</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">山達皇家祖魯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">02-13 20:09</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第44期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">02-12 23:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">歷基亞(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">克拉斯諾達爾</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.990</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">02-12 20:23</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第44期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">02-12 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">莫斯科中央陸軍(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5/3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">華拿倫加</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.920</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-3</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">02-11 20:16</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第44期</td>
    <td align=""center"" bgcolor=""#008888"" style=""color:#fff; font-size:14px"">葡超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">02-11 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">國民隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">受一球/球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">賓菲加</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">國民隊/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">02-10 23:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43期</td>
    <td align=""center"" bgcolor=""#0099CC"" style=""color:#fff; font-size:14px"">葡甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-12 23:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿魯卡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">波蒂蒙尼斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">波蒂蒙尼斯/0.910</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-12 15:34</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43期</td>
    <td align=""center"" bgcolor=""#663333"" style=""color:#fff; font-size:14px"">法甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-12 04:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴黎聖日門</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">阿些斯奧</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-11 12:27</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-10 21:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">卡拉布克士邦(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">威廉二世</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">威廉二世/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-10 16:04</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43期</td>
    <td align=""center"" bgcolor=""#996733"" style=""color:#fff; font-size:14px"">印度甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-09 18:15</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴得斯尤</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">球半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">派欖阿羅</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴得斯尤/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-09 13:55</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-08 23:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">鹿特丹斯巴達(中)</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">賀芬咸</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.870</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-08 21:46</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43期</td>
    <td align=""center"" bgcolor=""#297CA5"" style=""color:#fff; font-size:14px"">法國盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-08 03:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊斯特</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">受平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">華倫西恩斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊斯特/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-07 22:26</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43期</td>
    <td align=""center"" bgcolor=""#006633"" style=""color:#fff; font-size:14px"">西甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-07 04:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">馬略卡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">馬德里體育會</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.920</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-06 16:15</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第43期</td>
    <td align=""center"" bgcolor=""#438E0B"" style=""color:#fff; font-size:14px"">西乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-06 01:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">維拉利爾</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那B隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴塞羅那B隊/0.860</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-3</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">01-05 12:34</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#5E3000"" style=""color:#fff; font-size:14px"">土超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-15 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">伊斯基錫海斯普</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">柏薩士邦</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.880</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-14 22:29</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#008787"" style=""color:#fff; font-size:14px"">友誼賽</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-13 19:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">博爾切圖</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">維澤夫洛茲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.860</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-13 15:24</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#808080"" style=""color:#fff; font-size:14px"">英聯盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-13 03:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">史雲斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">米德爾斯堡</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">史雲斯/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-12 15:25</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#6F6161"" style=""color:#fff; font-size:14px"">法乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-12 03:55</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">利文斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">GFC阿些斯奧</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">GFC阿些斯奧/0.810</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-11 19:23</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#5F9292"" style=""color:#fff; font-size:14px"">波蘭甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-11 01:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">華沙普隆尼亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">沙斯辛</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.800</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-10 16:05</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#438E0B"" style=""color:#fff; font-size:14px"">西乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-09 19:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥杜巴</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">希杭</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">希杭/0.970</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-09 17:43</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#5F9292"" style=""color:#fff; font-size:14px"">波蘭甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-08 22:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">路賓</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">克拉科夫</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">克拉科夫/0.830</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">4-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-08 19:50</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#5F9292"" style=""color:#fff; font-size:14px"">波蘭甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-08 03:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">斯拉斯克</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">歷基亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.820</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-07 13:19</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#6F00DD"" style=""color:#fff; font-size:14px"">歐霸盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-07 02:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">哥本哈根</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布格勒斯特星隊</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">布格勒斯特星隊/0.880</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢半</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-06 21:33</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第42期</td>
    <td align=""center"" bgcolor=""#855074"" style=""color:#fff; font-size:14px"">女亞冠U19</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-05 17:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">越南女足U19</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3/3.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">台灣女足U19</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.850</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">12-05 15:55</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第41期</td>
    <td align=""center"" bgcolor=""#FF4C10"" style=""color:#fff; font-size:14px"">澳職聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11-03 18:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">珀斯光榮</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">紐卡斯托</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">小球/0.970</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">3-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11-03 14:54</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第41期</td>
    <td align=""center"" bgcolor=""#E6BE00"" style=""color:#fff; font-size:14px"">烏克U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11-02 19:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">薩克達U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">球半/两球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">米達雷治U21</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">薩克達U21/0.900</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11-02 18:26</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第41期</td>
    <td align=""center"" bgcolor=""#0088FF"" style=""color:#fff; font-size:14px"">意甲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11-02 03:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">熱拿亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">受平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">費倫天拿</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">費倫天拿/0.890</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11-01 21:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第41期</td>
    <td align=""center"" bgcolor=""#FA0052"" style=""color:#fff; font-size:14px"">荷蘭盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">11-01 01:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">RKC華域克</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">施禾尼</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">施禾尼/0.840</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-4</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-31 21:20</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第41期</td>
    <td align=""center"" bgcolor=""#a00800"" style=""color:#fff; font-size:14px"">德國盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-31 03:30</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">緬恩斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5/3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">艾格比治</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.860</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-30 19:48</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第41期</td>
    <td align=""center"" bgcolor=""#778800"" style=""color:#fff; font-size:14px"">蘇青聯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-30 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">盧加諾</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">平/半</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">溫特圖爾</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">溫特圖爾/0.940</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-29 22:35</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第40期</td>
    <td align=""center"" bgcolor=""#6490D2"" style=""color:#fff; font-size:14px"">匈聯盃</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-10 21:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">席歐福克</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">佩克斯</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.810</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-0</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-10 20:46</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第40期</td>
    <td align=""center"" bgcolor=""#E08B36"" style=""color:#fff; font-size:14px"">英依超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-10 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">馬格特</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">半/一</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">康戈爾流浪者</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">馬格特/0.880</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">0-2</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#333333"">输盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-09 20:11</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第40期</td>
    <td align=""center"" bgcolor=""#0076B1"" style=""color:#fff; font-size:14px"">意乙</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-09 02:45</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">利禾奴</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">2/2.5球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">士比西亞</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.810</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">1-5</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#FF0000"">赢盘</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-08 22:09</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">第40期</td>
    <td align=""center"" bgcolor=""#7a5c42"" style=""color:#fff; font-size:14px"">阿塞超</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-08 19:00</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">巴庫尼菲治</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#FF0000; font-size:14px"">3球</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">托武茲</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">大球/0.820</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">2-1</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px""><font color=""#006600"">走水</font></td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">10-08 17:13</td>
    <td align=""center"" bgcolor=""#FFFFFF"" style=""color:#0000D5; font-size:14px"">格力电器</td>
  </tr>

  <tr class=""menu"">
    <td height=""25"" colspan=""11"" align=""center"" bgcolor=""#FFFFFF""><div class=""tzpage"">当前页次：1 / 1 共 1 页 共 67 条 每页显示100条
 [首页] [上一页] [下一页] [尾页]</div></td>
  </tr>
</table>
<br />

</body></HTML>
";
        #endregion
    }
}
