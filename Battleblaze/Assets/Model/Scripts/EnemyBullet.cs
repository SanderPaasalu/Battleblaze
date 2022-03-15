using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Public variable that deals with bullet characteristics
    public int speed = 12;
    Rigidbody2D bulletBody;
    private float lookAngle;
    private Vector3 lookDirection;
    //[SerializeField] private GameObject player;
    public Rigidbody2D playerBody;

    // Function called when the object goes out of the screen
    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }

    public void Start()
    {

        // Get the rigidbody component
        bulletBody = GetComponent<Rigidbody2D>();
        //
        playerBody = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        // Make the bullet move upward relative to bullet's transform
        Rotate(bulletBody, playerBody);
        bulletBody.velocity = transform.up * speed;
    }

    // Function that deals with local rotation
    private void Rotate(Rigidbody2D body, Rigidbody2D player)
    {
        lookDirection = player.transform.position - body.transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        body.transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
