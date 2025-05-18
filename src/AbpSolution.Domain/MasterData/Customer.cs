using AbpSolution.BaseData;
using AbpSolution.Const;
using System.ComponentModel.DataAnnotations;

namespace AbpSolution.MasterData;

public class Customer : BaseEntity
{
    [MaxLength(EntityConst.MaxCodeLength)]
    public string PhoneNumber { get; set; }

    [MaxLength(EntityConst.MaxAddressLength)]
    public string Address { get; set; }
}
