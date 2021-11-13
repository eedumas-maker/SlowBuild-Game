using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowLight : IThrowBehaviors
{
    public void Throw(Rigidbody2D rb, Vector2 dir)
    {
        Debug.Log("ThrowLight Activated");
        rb.AddForce(dir);
    }
}
