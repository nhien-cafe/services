using AbpSolution.Const;
using AbpSolution.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.TransactionalData
{
    public class Invoice : FullAuditedAggregateRoot<Guid>
    {
        public Guid? TableId { get; set; }
        public Guid? CustomerId { get; set; }

        [MaxLength(EntityConst.MaxCodeLength)]
        public required string Code { get; set; }

        public Status Status { get; set; }

        [MaxLength(EntityConst.MaxDescriptionLength)]
        public string? Description { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal NetAmount { get; set; }

        public DiscountType? DiscountType { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }

        public ICollection<InvoiceItem> Details { get; set; } = new HashSet<InvoiceItem>();
    }
}
