using AbpSolution.Const;
using AbpSolution.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.BaseData;

public class BaseEntity : FullAuditedAggregateRoot<Guid>
{
    [MaxLength(EntityConst.MaxCodeLength)]
    public required string Code { get; set; }
    [MaxLength(EntityConst.MaxNameLength)]
    public required string Name { get; set; }
    public Status Status { get; set; }

    [MaxLength(EntityConst.MaxDescriptionLength)]
    public string? Description { get; set; }
}
