using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiasterController : MonoBehaviour
{
    private float speed;
    private float health = 100f;
    Rigidbody2D meteor;
    // Start is called before the first frame update
    void Start()
    {
        meteor = GetComponent<Rigidbody2D>();
        meteor.velocity = new Vector2(-5, -5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" || collision.tag == "Player")
        {
            health -= 1;
            if (health<= 0) { Destroy(gameObject); } 
        }
    }
}
