using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlUpShield : MonoBehaviour
{
    private LVLup lvlUp;
    private static float shieldUpgrades;
    private Text shieldText;
    // Start is called before the first frame update
    void Start()
    {
        shieldText = gameObject.GetComponent<Text>();
        shieldUpgrades = 0;
    }

    private void Update()
    {
        CurrentShieldUpgrades();
    }

    public void CurrentShieldUpgrades()
    {
        shieldUpgrades = LVLup.GetShieldUpgrades();

        shieldText.text = "Shield Upgrades: " + shieldUpgrades;
    }
}
