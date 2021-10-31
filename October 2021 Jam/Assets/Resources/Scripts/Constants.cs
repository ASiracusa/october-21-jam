using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GemCut {
    Lozenge,
    Marigold,
    Point,
    Rose,
    Table,
    Trap
}

public enum GemColor {
    Agate,
    Amethyst,
    Citrine,
    Diamond,
    Emerald,
    Garnet,
    Jade,
    Peridot,
    Ruby,
    Sapphire,
    Topaz,
    Turqoise
}

public enum Ability {
    Strength,
    Vulnerability,
    Weakness,
    Protection,
    Health,
    Petrification,
    Damage, 
    Restoration,
    Perception,
    Glowing,
    Blindness,
    Invisibility,
    Speed,
    Rooting,
    Slowness,
    Jumping,
    Regeneration,
    Leeching,
    Depletion,
    Absorption,
    Divination,
    Truthtelling,
    Confusion,
    Deception
}

public class Constants
{
    public static readonly Ability[] GEM_COLOR_ABILITIES = new Ability[] {
        Ability.Strength,
        Ability.Leeching,
        Ability.Regeneration,
        Ability.Health,
        Ability.Blindness,
        Ability.Slowness,
        Ability.Petrification,
        Ability.Confusion,
        Ability.Speed,
        Ability.Protection,
        Ability.Invisibility,
        Ability.Divination
    };

    public static readonly GemCut[] PRIMARY_GEM_CUTS = new GemCut[] {
        GemCut.Trap,
        GemCut.Rose,
        GemCut.Lozenge,
        GemCut.Marigold,
        GemCut.Marigold,
        GemCut.Trap,
        GemCut.Table,
        GemCut.Point,
        GemCut.Rose,
        GemCut.Table,
        GemCut.Point,
        GemCut.Lozenge
    };
}
