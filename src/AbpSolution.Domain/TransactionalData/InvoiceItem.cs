using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.TransactionalData;

public class InvoiceItem: CreationAuditedEntity<Guid>
{
    public Guid InvoiceId { get; set; }
    public Guid ItemId { get; set; }

    public decimal Price { get; set; }

    [MaxLength(1000)]
    public int Quantity { get; set; }

    public ICollection<InvoiceItemTopping> Toppings { get; set; } = new HashSet<InvoiceItemTopping>();
}
