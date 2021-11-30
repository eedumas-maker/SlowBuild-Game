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

    void FixedUpdate()
    {
        MovePlayer();
        FlipPlayerSprite();
    }

    private void MovePlayer()
    {
        transform.Translate(new Vector3(moveVal.x, moveVal.y, 0) * moveSpeed * Time.deltaTime);
    }
    private void FlipPlayerSprite()
    {
        Vector3 playerScale = transform.localScale;
        if (moveVal.x < 0)
        {
            playerScale.x = -1;
        }
        if (moveVal.x > 0)
        {
            playerScale.x = 1;
        }

        transform.localScale = playerScale;
    }

    
}
