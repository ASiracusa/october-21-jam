using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MagicItem
{
    public abstract string ItemName();
    public abstract void CauseMishap();
    public abstract void CreateItemGO();
}
