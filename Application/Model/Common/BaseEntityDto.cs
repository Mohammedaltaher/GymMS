using Domain.Common;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Common;
public abstract class BaseEntityDto
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public string CreatedById { get; set; }
    public string CreatedByName { get; set; }
}

