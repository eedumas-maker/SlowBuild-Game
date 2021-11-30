using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowMedium : IThrowBehaviors
{
    Rigidbody2D rb;

    public void Throw(Rigidbody2D rb, Vector2 dir)
    {
        rb.AddForce(dir);
    }

}
