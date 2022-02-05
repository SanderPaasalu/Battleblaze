using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvluphealth : MonoBehaviour        
{
    private LVLup lvlUp;
    private static float healthUpgrades;
    private Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        healthText = gameObject.GetComponent<Text>();
        healthUpgrades = 0;
    }

    private void Update()
    {
        CurrentHealthUpgrades();
    }

    public void CurrentHealthUpgrades()
    {
        healthUpgrades = LVLup.GetHealthUpgrades();

        healthText.text = "Health Upgrades: " + healthUpgrades;
    }
}
