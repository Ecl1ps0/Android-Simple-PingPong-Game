using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] float moveSpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        TouchPaddle();
    }

    void TouchPaddle()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(touchPosition.x < 0)
            {
                // move to the left 

                rb.velocity = Vector2.left * moveSpeed;
            } 
            else
            {
                // move to the right

                rb.velocity = Vector2.right * moveSpeed;
            }
        }
        else 
        {
            rb.velocity = Vector2.zero;
        }
    }
}
