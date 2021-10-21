using System;
namespace GraphAPIDemo.Model
{
    public static class OAuthSettings
    {
        public const string ApplicationId = "9909cdc8-3ad0-4ae1-a8be-6da35d0966e1";
        public const string Scopes = "User.Read MailboxSettings.Read Calendars.ReadWrite";
        public const string RedirectUri = "msauth://com.companyname.GraphDemo";
    }
}
