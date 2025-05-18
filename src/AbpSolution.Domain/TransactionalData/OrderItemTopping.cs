using AbpSolution.MasterData;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.TransactionalData;

public class OrderItemTopping: CreationAuditedEntity<Guid>
{
    public Guid OrderItemId {  get; set; }

    public Guid ToppingId { get; set; }

    [MaxLength(1000)]
    public int Quantity { get; set; }

    public decimal Price { get; set; }

    [ForeignKey(nameof(ToppingId))]
    public Item Topping { get; set; }
}
