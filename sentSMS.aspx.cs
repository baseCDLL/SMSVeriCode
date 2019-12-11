using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sentSMS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (TextBox1.Text.Trim() != "" && TextBox2.Text.Trim() != "")
            {
                string Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ITopClient client = new ITopClient();
                client.url = config.apiUrl;
                client.method = "snd.sms.send";
                client.logUser = config.userName;
                client.secretKey = config.secretKey;
                client.timestamp = Timestamp;
                client.sign = csMD5.Md5(config.userName + config.password + Timestamp);
                client.sentTel = TextBox1.Text.Trim();
                client.sentContent = TextBox2.Text.Trim();
                string reStr = defaultTopClient.sndCreateJson(ref client);
                if (JsonSplitExtention.IsJson(reStr))
                {
                    sentReturn jr = JsonConvert.DeserializeObject<sentReturn>(reStr);
                    //记录Id
                    int rId = jr.recordId;
                    //状态
                    string sentStaus = jr.requestStatus;
                    //返回时间
                    string sentTime = jr.responseTime;
                    Label2.Text = "<font color='blue'>记录ID：</font>" + rId + " <font color='blue'>状态值：</font>" + sentStaus + " <font color='blue'>返回时间：</font>" + sentTime;
                }
                else
                {
                    Label2.Text = defaultTopClient.sndCreateJson(ref client);
                }
            }
        }
        catch
        {

        }
    }
}