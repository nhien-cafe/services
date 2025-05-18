using AbpSolution.MasterData;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.ReferenceData;

public class ComboTopping : CreationAuditedEntity<Guid>
{
    public Guid ItemId { get; set; }
    public Guid ToppingId { get; set; }

    [ForeignKey(nameof(ItemId))]
    public Item Item { get; set; }

    [ForeignKey(nameof(ToppingId))]
    public Item Topping { get; set; }
}
