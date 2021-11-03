using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBotMovement : MonoBehaviour
{
    public Vector2 moveVal;
    public float moveSpeed;


    void OnMovement(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(moveVal.x, moveVal.y, 0) * moveSpeed * Time.deltaTime);
    }
}
