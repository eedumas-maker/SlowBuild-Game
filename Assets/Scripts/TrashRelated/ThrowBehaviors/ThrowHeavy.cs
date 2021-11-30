using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowHeavy : IThrowBehaviors
{
    Rigidbody2D rb;   

    
    public void Throw(Rigidbody2D rb, Vector2 dir)
    {
        Debug.Log("Throw Heavy");
        rb.AddForce(dir, ForceMode2D.Impulse);
    }
}
