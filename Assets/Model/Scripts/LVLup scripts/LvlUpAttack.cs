using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlUpAttack : MonoBehaviour
{
    private LVLup lvlUp;
    private static float attackUpgrades;
    private Text attackText;
    // Start is called before the first frame update
    void Start()
    {
        attackText = gameObject.GetComponent<Text>();
        attackUpgrades = 0;
    }

    private void Update()
    {
        CurrentAttackUpgrades();
    }

    public void CurrentAttackUpgrades()
    {
        attackUpgrades = LVLup.GetAttackUpgrades();

        attackText.text = "Attack Upgrades: " + attackUpgrades;
    }
}
