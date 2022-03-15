using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public GameObject playerModules;
    private SpriteRenderer target;
    public Sprite moduelPlaceholder;
    public void OnClick_Back()
    {
        MenuManager.OpenMenu(Menu.HUD, gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            MenuManager.OpenMenu(Menu.HUD, gameObject);
        }
    }

    private void OnEnable()
    {
        Debug.Log("Upgrades menu enabled");
        foreach (Transform module in playerModules.transform)
        {
            target = module.GetComponent<SpriteRenderer>();
            if (target.sprite == null)
            {
                target.sprite = moduelPlaceholder;
            }
            else
            {
                continue;
            };
        }
    }

    private void OnDisable()
    {
        Debug.Log("Upgrades menu disabled");
        foreach (Transform module in playerModules.transform)
        {
            target = module.GetComponent<SpriteRenderer>();
            if (target.sprite == moduelPlaceholder)
            {
                target.sprite = null;
            }
            else
            {
                continue;
            };
        }
    }

    public void buy(GameObject source)
    {
        foreach (Transform module in playerModules.transform)
        {
            target = module.GetComponent<SpriteRenderer>();
            if (target.sprite == moduelPlaceholder || target.sprite == null)
            {
                Debug.Log("Buying module");
                target.sprite = source.GetComponent<Image>().sprite;
                break;
            }
            else
            {
                continue;
            };
        }
    }
}
