using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class getReceipt : System.Web.UI.Page
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
            client.method = "snd.sms.getreceipt";
            client.logUser = config.userName;
            client.secretKey = config.secretKey;
            client.timestamp = Timestamp;
            client.sign = csMD5.Md5(config.userName + config.password + Timestamp);
            string reStr = defaultTopClient.sndCreateJson(ref client);
            if (JsonSplitExtention.IsJson(reStr))
            {
                receiptReturn jr = JsonConvert.DeserializeObject<receiptReturn>(reStr);
                string reHTMLStr = string.Empty;
                List<receiptReturnDetail> dataArray = jr.data;
                if (dataArray.Count <= 0)
                {
                    reHTMLStr = "暂时没有回执";
                }
                else
                {
                    for (int i = 0; i < dataArray.Count; i++)
                    {
                        reHTMLStr += "<br><font color='blue'>电话：</font>“" + dataArray[i].reTel.ToString() + "” <font color='blue'>回执值：</font>“" + dataArray[i].receiptStatus.ToString() + "” <font color='blue'>记录ID：</font>“" + dataArray[i].recordId.ToString() + "” <font color='blue'>回执时间：</font>“" + dataArray[i].receiptTime.ToString()+"”";
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