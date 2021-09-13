namespace ITServiceCompany.EmailSender
{
    using SendGrid;
    using SendGrid.Helpers.Mail;
    using System.Threading.Tasks;

    public class Example
    {
        //private const string apiKey = "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";
        //public static async Task Execute()
        //{
        //    var client = new SendGridClient(apiKey);
        //    var from = new EmailAddress("ivanbashtemski@gmail.com", "Example User");
        //    var subject = "Sending with SendGrid is Fun";
        //    var to = new EmailAddress("konstantinsaev07@gmail.com", "slick.us@slick.com");
        //    var plainTextContent = "and easy to do anywhere, even with C#";
        //    var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var response = await client.SendEmailAsync(msg);
        //}
    }
}
