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
    public class BaseModel
    {

        public object Data { get; set; }
        public int StatusCode { get; set; }
        public string Messege { get; set; }
    }
}
