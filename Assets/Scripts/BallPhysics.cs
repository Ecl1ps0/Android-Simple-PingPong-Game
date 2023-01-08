using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public float bounceForce;

    Rigidbody2D rb;
    bool gameStarted;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.anyKeyDown && !gameStarted)
        {
            StartBounce();

            gameStarted = true;

            GameManager.Instance.GameStart();
        }
    }

    void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);

        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "FallCheck")
        {
            GameManager.Instance.Restart();
        }
        else if(collision.gameObject.tag == "Paddle")
        {
            GameManager.Instance.ScoreUp();
        }
    }
}
