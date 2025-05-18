using AbpSolution.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.TransactionalData;

public class Order : CreationAuditedEntity<Guid>
{
    public Guid? TableId { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();

    [ForeignKey(nameof(TableId))]
    public Table Table { get; set; }
}
