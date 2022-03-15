using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuManager
{
    public static bool IsInitialized { get; private set; }
    public static GameObject hud, upgrades, gameOver;

    public static void Init()
    {
        GameObject canvas = GameObject.Find("Canvas");
        hud = canvas.transform.Find("HUD").gameObject;
        upgrades = canvas.transform.Find("Upgrades").gameObject;
        gameOver = canvas.transform.Find("GameOver").gameObject;

        IsInitialized = true;
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu = null, bool pause = false)
    {
        // ----------------------------------------------------------------
        // Params:
        // menu - Menu to be opened
        // (optional) callingMenu - The menu that called this function
        // (optional) pause - Specifies if the game should be paused or not
        // ----------------------------------------------------------------

        if (!IsInitialized || hud == null)
        {
            Init();
        }

        switch (menu)
        {
            case Menu.HUD:
                hud.SetActive(true);
                break;
            case Menu.UPGRADES:
                upgrades.SetActive(true);
                break;
            case Menu.GAME_OVER:
                gameOver.SetActive(true);
                break;
        }

        if (callingMenu != null)
        {
            callingMenu.SetActive(false);
        }

        if (pause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    // [SerializeField] private GameObject hud, upgrades, player;
    // public GameOverScreen GameOverScreen;

    // // If a menu can be opened via keybinds then that code should go here
    // private void Update()
    // {
    //     // Upgrades menu
    //     if (Input.GetKeyDown(KeyCode.T))
    //     {
    //         hud.SetActive(!hud.activeSelf);
    //         upgrades.SetActive(!upgrades.activeSelf);
    //         player.GetComponent<playerController>().enabled = !player.GetComponent<playerController>().enabled;
    //         Pause(upgrades.activeSelf);
    //     }
    // }

    // public void GameOver()
    // {
    //     Debug.Log("Game over");
    //     GameOverScreen.Setup(100);
    // }

    // public void Pause(bool value)
    // {
    //     // TODO - Implement script pausing
    //     if (value)
    //     {
    //         Time.timeScale = 0;
    //     }
    //     else
    //     {
    //         Time.timeScale = 1;
    //     }
    // }
}
