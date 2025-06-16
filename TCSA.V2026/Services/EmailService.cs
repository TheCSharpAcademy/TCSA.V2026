using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Services;

public interface ICustomEmailSender : IEmailSender<ApplicationUser>
{
    Task SendEmailAsync(string toEmail, string subject, string message);
    Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink);
    Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink);
    Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode);
}

public class EmailSender : ICustomEmailSender
{
    private readonly IConfiguration _configuration;
    private string _apiKey;

    public EmailSender(IConfiguration configuration, IOptions<AuthMessageSenderOptions> optionsAccessor)
    {
        Options = optionsAccessor.Value;
        _configuration = configuration;
        _apiKey = _configuration["Values:EmailKey"];
    }

    public AuthMessageSenderOptions Options { get; } //Set with Secret Manager.

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        if (string.IsNullOrEmpty(_apiKey))
        {
            throw new Exception("Null SendGridKey");
        }
        await Execute(_apiKey, subject, message, toEmail);
    }

    public async Task Execute(string apiKey, string subject, string message, string toEmail)
    {
        var client = new SendGridClient(apiKey);
        var msg = new SendGridMessage()
        {
            From = new EmailAddress("thecsharpacademy@gmail.com", "The C# Academy"),
            Subject = subject,
            PlainTextContent = message,
            HtmlContent = message
        };
        msg.AddTo(new EmailAddress(toEmail));

        // Disable click tracking.
        // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
        msg.SetClickTracking(false, false);
        var response = await client.SendEmailAsync(msg);
    }

    public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
    {
        throw new NotImplementedException();
    }

    public async Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
    {
        await SendEmailAsync(email, "Reset your password", $"Please reset your password by <a href='{resetLink}'>clicking here</a>.");
        Console.WriteLine("cazzo");
    }


    public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
        SendEmailAsync(email, "Reset your password", $"Please reset your password using the following code: {resetCode}");
}

public class AuthMessageSenderOptions
{
    public string? SendGridKey { get; set; }
}

public class CustomEmailConfirmationTokenProvider<TUser>
                              : DataProtectorTokenProvider<TUser> where TUser : class
{
    public CustomEmailConfirmationTokenProvider(
        IDataProtectionProvider dataProtectionProvider,
        IOptions<EmailConfirmationTokenProviderOptions> options,
        ILogger<DataProtectorTokenProvider<TUser>> logger)
                                       : base(dataProtectionProvider, options, logger)
    {

    }
}
public class EmailConfirmationTokenProviderOptions : DataProtectionTokenProviderOptions
{
    public EmailConfirmationTokenProviderOptions()
    {
        Name = "EmailDataProtectorTokenProvider";
        TokenLifespan = TimeSpan.FromHours(20);
    }
}