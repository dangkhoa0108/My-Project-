using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using Sitecore.Diagnostics;
using Sitecore.Security.Accounts;
using Sitecore.Workflows.Simple;

namespace SentEmail.Validate
{
    public class ValidateFile
    {
        public void Process(WorkflowPipelineArgs args)
        {
            var id = args.DataItem.Paths.Item.ID;
            var data = Sitecore.Data.Database.GetDatabase("master");
            var item = data.GetItem(id);
            var title = item.Fields["Title"].ToString();
            var phone = item.Fields["Phone"].ToString();
            var email = item.Fields["Email"].ToString();
            string comment = args.CommentFields["Comments"];
            if (string.IsNullOrWhiteSpace(title))
            {
                var e = "Title not null";
                SentFailEmail(args, e);
                Assert.IsFalse(true, e);
            }
            else
            {
                if (!IsEmail(email))
                {
                    var e = "Please input Email";
                    SentFailEmail(args, e);
                    Assert.IsFalse(true, e);
                }
                else
                {
                    if (!IsNumber(phone))
                    {
                        var e = "Please input number";
                        SentFailEmail(args, e);
                        Assert.IsFalse(true, e);
                    }
                    else
                    {
                        if (phone.Length >= 12 || phone.Length < 9)
                        {
                            var e = "Length > 9 and < 12";
                            SentFailEmail(args, e);
                            Assert.IsFalse(true, e);
                        }
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(comment))
            {
                var e = "Please input Comment";
                SentFailEmail(args, e);
                Assert.IsFalse(true, e);
            }

        }

        private bool IsNumber(string number)
        {
            bool isNum = double.TryParse(number, out _);
            return isNum;
        }

        private bool IsEmail(string email)
        {
            EmailAddressAttribute e = new EmailAddressAttribute();
            return e.IsValid(email);
        }

        private void SentFailEmail(WorkflowPipelineArgs args, string e)
        {
            var editorUser = GetEditorUser(args);
            var reviewerUser = Sitecore.Context.User;
            var subject = "Can't Approve";
            var message = "This content not approve because: " + e;
            SendMailConfig(reviewerUser.Profile.Email, editorUser.Profile.Email, subject, message);
        }

        private void SendMailConfig(string to, string from, string subject, string message)
        {
            MailMessage mail = new MailMessage { From = new MailAddress(@from) };
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
            if (contentHistory.Length <= 0) return null;
            var lastUser = contentHistory.Last().User;
            return User.FromName(lastUser, false);
        }
    }
}