using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public string Name { get; set; }
    public int InventorySpaceTaken { get; set; }
    public int Weight { get; set; }
    public int Value { get; set; }
    public Rigidbody2D rb;
    public IThrowBehaviors throwBehavior { get; set; }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = Weight;
    }

    public Trash()
    {
        if (Weight > 10) throwBehavior = new ThrowHeavy();
        else if (Weight > 5) throwBehavior = new ThrowMedium();
        else throwBehavior = new ThrowLight();
    }

}

