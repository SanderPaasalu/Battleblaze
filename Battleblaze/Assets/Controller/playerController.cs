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
    // Player's Modules
    // ---------- 
    public Module[] modules = new Module[8];


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

        InitiateModules();
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


    private void InitiateModules()
    {
        int i = 0;
        foreach (Transform moduleTransform in this.transform.Find("Modules"))
        {
            Debug.Log(moduleTransform.gameObject.name);
            modules[i].module = moduleTransform;
            modules[i].title = moduleTransform.gameObject.name;
            modules[i].description = "";
            modules[i].health = 0f;
            modules[i].shields = 0f;
            modules[i].damage = 0f;
            modules[i].speed = 0f;
            modules[i].sprite = null;

            i++;
        }

        return;
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
        if (collision.tag == "Meteor")
        {
            if (shield <= 0)
            {
                Health -= 5;
            }
            else
            {
                shield -= 5;
            }
        }
    }
}
