using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLup : MonoBehaviour
{
    private static float healthUpgrades, attackUpgrades, speedUpgrades, shieldUpgrades, skillPoints;

    // Start is called before the first frame update
    void Awake()
    {
        healthUpgrades = 0;
        attackUpgrades = 0;
        speedUpgrades = 0;
        shieldUpgrades = 0;
        skillPoints = 0;
    }

    // Functions for setting and getting current upgrade lvls
    public static void SetHealthUpgrades()
    {
        healthUpgrades += 1;
    }

    public static float GetHealthUpgrades()
    {
        return healthUpgrades;
    }
    public static void SetAttackUpgrades()
    {
        attackUpgrades += 1;
    }

    public static float GetAttackUpgrades()
    {

        return attackUpgrades;
    }
    public static void SetSpeedUpgrades()
    {
        speedUpgrades += 1;
    }

    public static float GetSpeedUpgrades()
    {

        return speedUpgrades;
    }

    public static void SetShieldUpgrades()
    {
        shieldUpgrades += 1;
    }

    public static float GetShieldUpgrades()
    {

        return shieldUpgrades;
    }

    public static void SkillPoints()
    {
        skillPoints += 1;
    }

    public static float GetSkillPoints()
    {
        return skillPoints;
    }
}
