using System;
using System.Collections.Generic;

namespace ytcg_eGuideAPI.Entities;

public partial class OwnedCard
{
    public int? UserId { get; set; }

    public int? StarterId { get; set; }

    public bool? IsOwned { get; set; }

    public int Id { get; set; }

    public virtual StarterPack? Starter { get; set; }

    public virtual User? User { get; set; }
}
