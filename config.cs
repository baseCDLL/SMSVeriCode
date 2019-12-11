using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// config 的摘要说明
/// </summary>
public static class config
{
    //请求地址
    public static string apiUrl = "https://snd.kim/SMSVCAPI/rest";
    //登录账号
    public static string userName = "";
    //登录密码
    public static string password = "";
    //账号私匙（secretKey），在后台API文档里的请求参数那儿查看。
    public static string secretKey = "";
}