using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Mail;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public int MailSend(string To, string Message)
    {
        MailMessage Msg = new MailMessage();
        Msg.From = new MailAddress("mithunjadhav14@gmail.com"); // Sender e-mail address.
        Msg.To.Add("mithunjadhav14@gmail.com");// Recipient e-mail address.
        Msg.Subject = "Send Mail Using WebServices";
        Msg.Body = Message;
        Msg.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("mithunjadhav14@gmail.com", "9890547423");
        smtp.EnableSsl = true;
        smtp.Send(Msg);
        return 1;
    }

}