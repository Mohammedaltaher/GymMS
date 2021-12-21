using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities;
public class AdditionalFeature : BaseEntity
{
    public string Name { get; set; }
    public HallTypeEnum Type { get; set; }
}
