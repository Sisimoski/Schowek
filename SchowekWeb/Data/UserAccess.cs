using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace SchowekWeb.Data
{
    public class UserAccess
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserAccess(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserIdData()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated == true)
            {
                return _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            }
            else
            {
                return "Brak danych uwierzytelniania.";
            }
        }
    }
}
