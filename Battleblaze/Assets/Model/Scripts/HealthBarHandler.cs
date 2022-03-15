using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHandler : MonoBehaviour
{
    private static Image HealthBarImage;

    // Initialize the variable
    private void Start()
    {
        HealthBarImage = GetComponent<Image>();
    }

    // Sets the health bar value
    public static void SetHealthBarValue(float value)
    {
        HealthBarImage.fillAmount = value;

        if (HealthBarImage.fillAmount < 0.3f)
        {
            SetHealthBarColor(new Color32(219, 45, 76, 255));
        }
    }

    public static float GetHealthBarValue()
    {
        return HealthBarImage.fillAmount;
    }

    // Sets the health bar color
    public static void SetHealthBarColor(Color healthColor)
    {
        HealthBarImage.color = healthColor;
    }
}
