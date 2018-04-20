using System.Linq;
using System.Net;
using System.Net.Mail;
using Sitecore.Data.Items;
using Sitecore.Security.Accounts;
using Sitecore.Workflows.Simple;

namespace SentEmail.SentMail
{
    public class SentMail
    {
        public void Process(WorkflowPipelineArgs args)
        {
            Item innerItem = args.ProcessorItem.InnerItem;
            string subject = innerItem["Subject"];
            string message = innerItem["Message"];
            var editorUser = GetEditorUser(args);
            var reviewerUser = Sitecore.Context.User;
            string comment = args.CommentFields["Comments"];

            message = message.Replace("$to$", editorUser.Profile.FullName)
            .Replace("$from$", reviewerUser.Profile.FullName)
            .Replace("$itempath$", args.DataItem.Paths.Path)
            .Replace("$itemLanguage$",
            args.DataItem.Language.Name)
            .Replace("$itemVersion$",
            args.DataItem.Version.ToString())
            .Replace("$comments$", comment);
            SendMail(reviewerUser.Profile.Email, editorUser.Profile.Email, subject, message);

        }

        private void SendMail(string from, string to, string subject, string message)
        {
            MailMessage mail = new MailMessage {From = new MailAddress(@from)};
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = message;
            mail.IsBodyHtml = true;
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential("khoatd@smartosc.com", "cuntho21010711");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }

        private User GetEditorUser(WorkflowPipelineArgs args)
        {
            var item = args.DataItem;

            var contentWorkflow = item.Database.WorkflowProvider.GetWorkflow(item);
            var contentHistory = contentWorkflow.GetHistory(item);

            if (contentHistory.Length > 0)
            {
                var lastUser = contentHistory.Last().User;
                return User.FromName(lastUser, false);
            }
            return null;
        }
    }
}