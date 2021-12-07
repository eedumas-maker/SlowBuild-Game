using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEffectorScript : MonoBehaviour
{



    void Start()
    {
        DrawPolygonCollider(GetComponent<PolygonCollider2D>());
    }

    void OnGUI()
    {


    }

    private void Update()
    {
        //var mousePosition = PlayerActions.actions["Look"].ReadValue<Vector2>();
        //var projectedMousePosition = Camera.ScreenToWorldPoint(mousePosition);

        //Vector2 direction = mousePosition - transform.position;
        //float angle = Vector2.SignedAngle(Vector2.right, direction);

        //Vector3 targetRotation = new Vector3(0, 0, angle - 90);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), 360);

    }

    public static void DrawPolygonCollider(PolygonCollider2D collider)
    {
        LineRenderer _lr = collider.gameObject.AddComponent<LineRenderer>();
        _lr.startWidth = 0.025f;
        _lr.endWidth = 0.025f;
        _lr.useWorldSpace = false;
        _lr.positionCount = collider.points.Length + 1;
        for (int i = 0; i < collider.points.Length; i++)
        {
            _lr.SetPosition(i, new Vector3(collider.points[i].x, collider.points[i].y));
        }
        _lr.SetPosition(collider.points.Length, new Vector3(collider.points[0].x, collider.points[0].y));
    }

}
