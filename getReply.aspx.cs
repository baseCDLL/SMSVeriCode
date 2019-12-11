using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class getReply : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ITopClient client = new ITopClient();
            client.url = config.apiUrl;
            client.method = "snd.sms.reply";
            client.logUser = config.userName;
            client.secretKey = config.secretKey;
            client.timestamp = Timestamp;
            client.sign = csMD5.Md5(config.userName + config.password + Timestamp);
            string reStr = defaultTopClient.sndCreateJson(ref client);
            if (JsonSplitExtention.IsJson(reStr))
            {
                replyReturn rr = JsonConvert.DeserializeObject<replyReturn>(reStr);
                List<replyReturnDetail> rrd = rr.data;
                string reHTMLStr = string.Empty;
                if (rrd.Count <= 0)
                {
                    reHTMLStr = "暂时没有回复";
                }
                else
                {
                    for (int i = 0; i < rrd.Count; i++)
                    {
                        reHTMLStr += "<br><font color='blue'>回复电话：</font>“" + rrd[i].sentTel.ToString() + "” <font color='blue'>回复内容：</font>“" + rrd[i].replyContent.ToString() + "” <font color='blue'>回复时间：</font>“" + rrd[i].replyTime.ToString()+"”";
                    }
                }
                Label2.Text = reHTMLStr;
            }
            else
            {
                Label2.Text = defaultTopClient.sndCreateJson(ref client);
            }
        }
        catch
        {

        }
    }
}