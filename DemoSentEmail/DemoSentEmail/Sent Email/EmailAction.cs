using System;
using System.Net;
using System.Net.Mail;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Workflows.Simple;

namespace DemoSentEmail.Sent_Email
{
    public class EmailAction
    {
        public void Process(WorkflowPipelineArgs args)
        {
            Assert.ArgumentNotNull(args, "args");
            ProcessorItem processorItem = args.ProcessorItem;
            if (processorItem != null)
            {
                Item innerItem = processorItem.InnerItem;
                string fullPath = innerItem.Paths.FullPath;
                string from = GetText(innerItem, "from", args);
                string to = GetText(innerItem, "to", args);
                string host = GetText(innerItem, "mail server", args);
                string subject = GetText(innerItem, "subject", args);
                string body = GetText(innerItem, "message", args);
                Error.Assert(to.Length > 0, "The 'To' field is not specified in the mail action item: " + fullPath);
                Error.Assert(from.Length > 0, "The 'From' field is not specified in the mail action item: " + fullPath);
                Error.Assert(subject.Length > 0,
                             "The 'Subject' field is not specified in the mail action item: " + fullPath);
                Error.Assert(host.Length > 0,
                             "The 'Mail server' field is not specified in the mail action item: " + fullPath);

                //var message = new MailMessage(from, to);
                //message.Subject = subject;
                //message.Body = body;
                ////new SmtpClient(host,587).Send(message);
               
                //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                //smtp.EnableSsl = true;
                //smtp.UseDefaultCredentials = false;
                //smtp.Credentials = new NetworkCredential("tdangkhoa.itute@gmail.com", "cuntho21010711");                
                //smtp.Send(message);

                SmtpClient smtpclient = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential("tdangkhoa.itute@gmail.com", "cuntho21010711"),
                    EnableSsl = true
                };
                MailMessage objmsg = new MailMessage {From = new MailAddress(@from)};
                objmsg.To.Add(to);
                objmsg.Subject = subject;
                objmsg.Body = body+"vao day";
                objmsg.IsBodyHtml = true;
                smtpclient.Send(objmsg);
            }
        }

        private string GetText(Item commandItem, string field, WorkflowPipelineArgs args)
        {
            string text = commandItem[field];
            if (text.Length <= 0) return String.Empty;

            return ReplaceVariables(text, args);
        }

        private string ReplaceVariables(string text, WorkflowPipelineArgs args)
        {
            Item workflowItem = args.DataItem;

            text = text.Replace("$itemPath$", workflowItem.Paths.FullPath);
            text = text.Replace("$itemLanguage$", workflowItem.Language.ToString());
            text = text.Replace("$itemVersion$", workflowItem.Version.ToString());

            /*  TODO: Add custom code here resolve new tokens.
             *  text = text.Replace("$token$", yourMethodToResolveTheToken());
             */

            return text;
        }
    }
}