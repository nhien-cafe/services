using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.ReferenceData;

public class PriceListDetail : CreationAuditedEntity<Guid>
{
    public Guid PriceListId { get; set; }

    public Guid ItemId { get; set; }

    public decimal Price { get; set; }

}
