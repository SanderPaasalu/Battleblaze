using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlUpSpeed : MonoBehaviour
{
    private LVLup lvlUp;
    private static float speedUpgrades;
    private Text speedText;
    // Start is called before the first frame update
    void Start()
    {
        speedText = gameObject.GetComponent<Text>();
        speedUpgrades = 0;
    }

    private void Update()
    {
        CurrentSpeedUpgrades();
    }

    public void CurrentSpeedUpgrades()
    {
        speedUpgrades = LVLup.GetSpeedUpgrades();

        speedText.text = "Speed Upgrades: " + speedUpgrades;
    }
}
