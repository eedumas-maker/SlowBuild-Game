using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IThrowBehaviors 
{
    public void Throw(Rigidbody2D rb, Vector2 dir);
}
