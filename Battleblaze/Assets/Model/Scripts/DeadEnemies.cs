using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEnemies : MonoBehaviour
{
    public static float EnemiesKilled;
    // Start is called before the first frame update
    void Start()
    {
        EnemiesKilled = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    public static void GetDead()
    {
        EnemiesKilled += 1;
        Debug.Log("I have been called: " + EnemiesKilled);
    }
}
