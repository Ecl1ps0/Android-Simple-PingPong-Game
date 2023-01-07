using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float bounceForce;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.anyKeyDown)
        {
            StartBounce();
        }
    }

    void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);

        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }
}
