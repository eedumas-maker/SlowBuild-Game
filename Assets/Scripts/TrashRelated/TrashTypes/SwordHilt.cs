using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHilt : Trash
{
    public SwordHilt() : base()
    {
        Name = "SwordHilt";
        InventorySpaceTaken = 2;
        Weight = 20;
        Value = 1;
        throwBehavior = new ThrowHeavy();
    }
}
