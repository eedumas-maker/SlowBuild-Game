using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AimTool: MonoBehaviour
{
    private Transform aimTransform;

    Vector2 mousePosition;

    private void Awake()
    {
        aimTransform = transform.Find("VacStick");
    }


    private void Update()
    {
        HandleAiming();
        HandleSucking();
    }

    private void HandleSucking()
    {
        bool isSucking = false;
        // i want it to be a toggle, so if it isn't sucking it starts
        // and if it is sucking it stops

        if(Mouse.current.leftButton.isPressed)
        {
            if(isSucking == false)
            {
                isSucking = true;

                // activate point effector here, and draw it too!
                // i guess by setting it to active?

            }
            else
            {
                isSucking = false;
            }

        }
    }

    private void HandleAiming()
    {
        mousePosition = Mouse.current.position.ReadValue();

        Vector3 mouseCamera = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = (mouseCamera - transform.position).normalized;

        float angle = Vector2.SignedAngle(Vector2.right, direction);

        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    //public static void DrawPolygonCollider(PolygonCollider2D collider)
    //{
    //    LineRenderer _lr = collider.gameObject.AddComponent<LineRenderer>();
    //    _lr.startWidth = 0.025f;
    //    _lr.endWidth = 0.025f;
    //    _lr.useWorldSpace = false;
    //    _lr.positionCount = collider.points.Length + 1;
    //    for (int i = 0; i < collider.points.Length; i++)
    //    {
    //        _lr.SetPosition(i, new Vector3(collider.points[i].x, collider.points[i].y));
    //    }
    //    _lr.SetPosition(collider.points.Length, new Vector3(collider.points[0].x, collider.points[0].y));
    //}

}
