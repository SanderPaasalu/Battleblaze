using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int xp;
    public static int supplies;
    private float shield = 10f;
    private float health = 10f;
    public float Shield { get { return shield; } }
    public float Health { get { return health; } }

    void Awake()
    {
        xp = 0;
        supplies = 0;
    }

    void Update()
    {
        supplies = (int)(DeadEnemies.EnemiesKilled * 10f);
        xp = (int)(DeadEnemies.EnemiesKilled * 9f);

        if (supplies > 999)
        {
            supplies = 999;
        }

    }
}
