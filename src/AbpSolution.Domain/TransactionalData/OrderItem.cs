using AbpSolution.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.TransactionalData;

public class OrderItem : CreationAuditedEntity<Guid>
{
    public Guid OrderId { get; set; }
    public Guid ItemId { get; set; }
    public decimal Price { get; set; }

    [MaxLength(1000)]
    public int Quantity { get; set; }

    public ICollection<OrderItemTopping> Toppings { get; set; } = new HashSet<OrderItemTopping>();

    [ForeignKey(nameof(OrderId))]
    public Order Order { get; set; }

    [ForeignKey(nameof(ItemId))]
    public Item Item { get; set; }
}
