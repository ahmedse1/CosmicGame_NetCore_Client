﻿using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Web;
namespace Utility
{
    public static class clsCommon
    {
        
        public static DateTime GetDateTime()
        {
            return DateTime.UtcNow.AddHours(5.5);
        }
        public static string GetTemplateBody(string Path)
        {
            string Strbody = "";
            //Strbody = readFile(Server.MapPath("~/EmailTemplates/" + template));
            Strbody = readFile(Path);

            Strbody = Strbody.Replace("`facebook`", "");
            Strbody = Strbody.Replace("`twitter`", "");
            Strbody = Strbody.Replace("`linkedin`", "");
            Strbody = Strbody.Replace("`google`", "");
            Strbody = Strbody.Replace("`instagram`", "");

            Strbody = Strbody.Replace("`SiteName`", "Cosmic Game");
            Strbody = Strbody.Replace("`SiteUrl`", GlobalVars.SiteUrl);
            Strbody = Strbody.Replace("`SitePhone`", "");
            Strbody = Strbody.Replace("`SiteEmail`", "");
            Strbody = Strbody.Replace("`logo`", "");
            Strbody = Strbody.Replace("`ahome`", "");
            Strbody = Strbody.Replace("`lnkContact`", "");
            return Strbody;
        }
        public static string readFile(string strFileName)
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader(strFileName);
            string s = "";
            try
            {
                do
                {
                    s += streamReader.ReadLine();
                } while (streamReader.Peek() != -1);
            }
            catch
            {
                s = "File is empty";
            }
            finally
            {
                streamReader.Close();
            }
            return s;
        }
        public static string SendEmail(string strTO, string strCC, string strSubject, string strBody, string[] attachment = null)
        {
            try
            {
                MailMessage email = new MailMessage();
                SmtpClient smtp = new SmtpClient(GlobalVars.SenderEmailSMTP);
                smtp.Port = int.Parse(GlobalVars.SenderEmailPort);

                System.Net.NetworkCredential creadintial = new System.Net.NetworkCredential(GlobalVars.SenderEmail, GlobalVars.SenderEmailPassword);

                smtp.Credentials = creadintial;
                //smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = GlobalVars.SenderEmailSSL;
                email.From = new MailAddress(GlobalVars.SenderEmail);

                email.To.Add(strTO);

                if (strCC != null && strCC.Trim() != "")
                    email.CC.Add(strCC);

                try
                {
                    if (attachment != null && attachment.Length > 0)
                    {
                        for (int i = 0; i < attachment.Length; i++)
                        {
                            email.Attachments.Add(new Attachment(attachment[i]));
                        }
                    }
                }
                catch { }

                email.Subject = strSubject;
                email.IsBodyHtml = true;
                email.Body = strBody;

                smtp.Send(email);
                email.Dispose();
                return "true";
            }
            catch (Exception e)
            {
                return "false:Email Sending Fail.!\nConfigure EMail Settings";// +e.ToString();
            }
        }

    }
}
