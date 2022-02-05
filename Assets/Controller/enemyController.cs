using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    float cooldown = 0.5f;
    float health = 10.0f;
    //float flashedFor = 0f;

    Color originalColor;
    // TODO: use enemies script to get the health, damage and speed of enemy
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1.5f;

    // Bullet game object, used for creating bullets
    public GameObject bullet;

    // Body of the enemy
    private Rigidbody2D enemyBody;

    // Stores the dif between enemy's and the player's transforms
    private Vector2 transformDif;

    private void Start()
    {
        enemyBody = GetComponent<Rigidbody2D>();
        originalColor = enemyBody.GetComponent<Renderer>().material.color;
    }


    void Update()
    {
        TowardsPlayer();
        // Enemy shooting
        cooldown -= Time.deltaTime;
        if(cooldown <= 0)
        {
            cooldown = 0.5f;
            Instantiate(bullet, transform.position, Quaternion.identity);   
        }
    }

    public void TowardsPlayer()
    {
        transformDif = player.transform.position - transform.position;
        // sets Enemy to move towards player
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        // Makes the enemy face towards the player
        transform.up = new Vector2(transformDif.x, transformDif.y);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TakeDamage(1);
        }
    }

    //
    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            DeadEnemies.GetDead();
            Destroy(gameObject);            
        }

        // Flash red when hit
        Flash();
    }

    private void Flash()
    {
        enemyBody.GetComponent<Renderer>().material.color = Color.red;
        Invoke("ResetColor", 0.05f);
    }

    private void ResetColor()
    {
        enemyBody.GetComponent<Renderer>().material.color = originalColor;
    }
}
