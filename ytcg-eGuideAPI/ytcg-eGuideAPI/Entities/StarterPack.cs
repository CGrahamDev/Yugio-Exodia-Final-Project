using System;
using System.Collections.Generic;

namespace ytcg_eGuideAPI.Entities;

public partial class StarterPack
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? FrameType { get; set; }

    public string Description { get; set; } = null!;

    public int Atk { get; set; }

    public int Def { get; set; }

    public int Level { get; set; }

    public string Race { get; set; } = null!;

    public string Attribute { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public virtual ICollection<OwnedCard> OwnedCards { get; set; } = new List<OwnedCard>();
}
