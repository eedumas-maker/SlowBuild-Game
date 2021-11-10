using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public string Name { get; set; }
    public int InventorySpaceTaken { get; set; }
    public int Weight { get; set; }
    public int Value { get; set; }

}

public class TinCan : Trash
{
    public void InitializeTinCan()
    {
        Name = "Tin Can";
        InventorySpaceTaken = 1;
        Weight = 5;
        Value = 1;
    }
}