using AbpSolution.BaseData;
using AbpSolution.Const;
using AbpSolution.Enum;
using AbpSolution.ReferenceData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbpSolution.MasterData;

public class Item : BaseEntity
{
    [MaxLength(EntityConst.MaxImageLength)]
    public string? ItemImage { get; private set; }

    public float Price { get; set; }

    public Guid GroupItemId { get; set; }

    [ForeignKey(nameof(GroupItemId))]
    public GroupItem GroupItem { get; set; }

    public ItemType ItemType { get; set; }

    [InverseProperty(nameof(ComboItem.Item))]
    public ICollection<ComboItem> ComboItems { get; set; } = new HashSet<ComboItem>();

    [InverseProperty(nameof(ComboTopping.Item))]
    public ICollection<ComboTopping> ComboToppings { get; set; } = new HashSet<ComboTopping>();
}
