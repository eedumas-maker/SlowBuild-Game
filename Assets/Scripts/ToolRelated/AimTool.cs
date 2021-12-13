using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AimTool: MonoBehaviour
{
    private Transform aimTransform;

    Vector2 mousePosition;

    private PointEffector2D sucker;

    private PolygonCollider2D outline;

    bool isSucking = false;

    [SerializeField] private Transform pfDelivery;

    private void Awake()
    {
        aimTransform = transform.Find("VacStick");
    }

    private void Start()
    {
        sucker = GetComponent<PointEffector2D>(); // woah there's a get component in children/parent too!
        outline = GetComponent<PolygonCollider2D>();

        DrawPolygonCollider(outline);
        gameObject.GetComponent<LineRenderer>().enabled = false;

        // ya gotta draw it first then turn it off right away
    }


    private void Update()
    {
        HandleAiming();
        HandleSucking();
        HandleShooting();
    }

    private void HandleSucking()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            if(isSucking == false)
            {
                isSucking = true;

                sucker.enabled = true;

                gameObject.GetComponent<LineRenderer>().enabled = true;

            }
            else
            {
                isSucking = false;

                sucker.enabled = false;

                gameObject.GetComponent<LineRenderer>().enabled = false; 
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

    public void HandleShooting()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Transform deliveryTransform = Instantiate(pfDelivery, transform.position, Quaternion.identity);

        }
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
