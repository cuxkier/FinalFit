//using RestSharp;
//using RestSharp.Authenticators;
//using System.IO;

//public class MailGunService
//{
//    private const string MailGunApiKey = "YOUR_MAILGUN_API_KEY";
//    private const string MailGunDomain = "YOUR_MAILGUN_DOMAIN";

//    public void SendEmailWithAttachment(string recipientEmail, string subject, string message, string attachmentFilePath)
//    {
//        var client = new RestClient($"https://api.mailgun.net/v3/{MailGunDomain}/messages");
//        client.Authenticator = new HttpBasicAuthenticator("api", MailGunApiKey);

//        var request = new RestRequest(RestRequest.POST);
//        request.AddParameter("from", "your-email@example.com");
//        request.AddParameter("to", recipientEmail);
//        request.AddParameter("subject", subject);
//        request.AddParameter("text", message);

//        // Załącz plik PDF
//        request.AddFile("attachment", File.ReadAllBytes(attachmentFilePath), Path.GetFileName(attachmentFilePath));

//        var response = client.Execute(request);
//        if (response.IsSuccessful)
//        {
//            Console.WriteLine("Email sent successfully!");
//        }
//        else
//        {
//            Console.WriteLine($"Failed to send email: {response.ErrorMessage}");
//        }
//    }
//}
