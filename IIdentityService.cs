namespace MyFirstApp.Features.Identity
{
    using System;

    public interface IIdentityService
    {
        string GenerateJwtToken(string userId, string userName, string secret);

    }
}
