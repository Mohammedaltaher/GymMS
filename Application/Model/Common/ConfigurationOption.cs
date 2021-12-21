using Domain.Common;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Common
{
    public class JWTToken
    {
       public string Token { get; set; }
       public DateTime? Expiration { get; set; }
    }
    public class AppsettingOptions
    {
        public const string Appsetting = "Appsetting";

        public ConnectionStringsOptions ConnectionStrings { get; set; }
        public JWTOptions Jwt { get; set; }

    }
    public class ConnectionStringsOptions
    {
        public const string ConnectionStrings = "ConnectionStrings";

        public string DefaultConnection { get; set; }

    }
    public class JWTOptions
    {
        public const string JWT = "JWT";
        public string Secret { get; set; }
        public string Key { get; set; }
        public string Issuer { get; set; }
    }
}
