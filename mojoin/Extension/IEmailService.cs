﻿namespace mojoin.Extension
{
    public interface IEmailService
    {
        Task SendEmail(string toEmail, string subject, string body);
    }


}
