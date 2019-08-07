using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MailSender : MonoBehaviour
{
    string email_string = "dashamerz@gmail.com";
    string subject_string = "От пользователя";
    string body_string = " ";

    public void SendEmail()
    {
        string email = email_string;
        string subject = EscapeURLFunction(subject_string);
        string body = EscapeURLFunction(body_string);
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string EscapeURLFunction(string url)
    {
        return UnityWebRequest.EscapeURL(url).Replace("+", "%20");
    }
}
