using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Trash
{
    
    public Pizza() : base()
    {
        Name = "Old Pizza";
        InventorySpaceTaken = 1;
        Weight = 1;
        Value = 0;
    }

}