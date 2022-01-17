using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // ----------
    // Dependencies
    // ----------
    private static HUD hud;
    private LVLup lvlUp;
    private MovementBehaviourScript Movement;
    private Player player;

    // ----------
    // Player & Player stats
    // ----------
    Rigidbody2D playerBody;
    private float shield;
    private float health;
    private float healthUpgrades = LVLup.GetHealthUpgrades();
    private float shieldUpgrades = LVLup.GetShieldUpgrades();

    public float Health
    {
        get { return health; }
        set
        {
            health = value;
            hud.Health = health;

            Debug.Log(health);
        }
    }

    // ----------
    // Shooting
    // ----------
    public GameObject bullet;
    public float cooldownTimer = 1f;
    private float cooldown;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        Movement = gameObject.AddComponent<MovementBehaviourScript>();
        player = gameObject.AddComponent<Player>();
        // hud = gameObject.AddComponent<HUD>();
        hud = GameObject.Find("Canvas").transform.Find("HUD").GetComponent<HUD>();
        cooldown = cooldownTimer;
        shield = player.Shield + shieldUpgrades;
        health = player.Health + healthUpgrades;
    }

    void Update()
    {
        Movement.MovePlayer(playerBody);

        // Player shooting
        cooldown -= Time.deltaTime;
        if (Input.GetMouseButton(0) && cooldown <= 0f)
        {
            cooldown = cooldownTimer;
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    // ----------
    // COLLISION
    // ----------
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyBullet" || collision.tag == "Enemy")
        {
            if (shield <= 0)
            {
                Health -= 1;
            }
            else
            {
                shield -= 1;
            }
        }
    }
}
