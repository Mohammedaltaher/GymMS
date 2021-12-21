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
    public class JWTTokenModel
    {
       public string Token { get; set; }
       public DateTime? Expiration { get; set; }
    }
    public class AppsettingModel
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public JWTModel Jwt { get; set; }

    }
    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }

    }
    public class JWTModel
    {
        public string Secret { get; set; }
        public string Key { get; set; }
        public string Issuer { get; set; }
    }
}
