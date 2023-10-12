using Azure;
using Azure.Communication.Email;
using System;
using System.Threading.Tasks;

namespace SendEmail
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello! Email has been triggered!!");
            // This code demonstrates how to send email using Azure Communication Services.
            var connectionString = "endpoint=https://emailservicemob.unitedstates.communication.azure.com/;accesskey=DIiuFH9fF7SsGk/9u18MLe0f4Ca5BCRIkr2kkmJSuOwmeZUzD7SJuO4y5xFyg+Skhu56uLD0xUiQ1g6jjxK7/w==";
            var emailClient = new EmailClient(connectionString);

            var sender = "DoNotReply@803892c2-7545-4819-a6f6-d6505c9b542e.azurecomm.net";
            var recipient = "krishnaveerakishoremuppana@gmail.com";
            var subject = "Send email quick start - dotnet";
            var htmlContent = "<html><body><h1>Quick send email test</h1><br/><h4>Communication email as a service mail send app working properly</h4><p>Happy Learning!!</p></body></html>";
            
            try 
            {
                Console.WriteLine("Start of email..");
                var emailSendOperation = await emailClient.SendAsync(
                    wait: WaitUntil.Completed,
                    senderAddress: sender, // The email address of the domain registered with the Communication Services resource
                    recipientAddress: recipient,
                    subject: subject,
                    htmlContent: htmlContent);
                Console.WriteLine($"Email Sent. Status = {emailSendOperation.Value.Status}");

                /// Get the OperationId so that it can be used for tracking the message for troubleshooting
                string operationId = emailSendOperation.Id;
                Console.WriteLine($"Email operation id = {operationId}");
            }
            catch (RequestFailedException ex)
            {
                /// OperationID is contained in the exception message and can be used for troubleshooting purposes
                Console.WriteLine($"Email send operation failed with error code: {ex.ErrorCode}, message: {ex.Message}");
            }
        }
    }
}
