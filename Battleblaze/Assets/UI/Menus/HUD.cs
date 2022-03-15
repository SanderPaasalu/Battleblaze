using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    private float health;
    private Player player;
    public float Health
    {
        set
        {
            health = value / 10f;
            healthBar.fillAmount = health;

            if (healthBar.fillAmount <= 0.35f)
                healthBar.color = new Color32(219, 45, 76, 255);

            if (health <= 0f)
                MenuManager.OpenMenu(Menu.GAME_OVER, gameObject, true);
        }
    }

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        healthBar = GameObject.Find("Health_bar").GetComponent<Image>();
    }

    private void Update()
    {
        // Upgrades menu
        if (Input.GetKeyDown(KeyCode.T))
        {
            MenuManager.OpenMenu(Menu.UPGRADES, MenuManager.hud, true);
        }
    }
}
