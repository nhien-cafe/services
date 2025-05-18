using AbpSolution.MasterData;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.ReferenceData;

public class ComboItem : CreationAuditedEntity<Guid>
{
    public Guid ComboId { get; set; }
    public Guid ItemId { get; set; }

    [ForeignKey(nameof(ComboId))]
    public Item Combo { get; set; }

    [ForeignKey(nameof(ItemId))]
    public Item Item { get; set; }
}
