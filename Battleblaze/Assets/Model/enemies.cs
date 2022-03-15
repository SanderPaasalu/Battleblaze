using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     private float moveSpeed = 1.5f;
     private float attackDamage = 1.0f;
     private float lifePoints = 10.0f;

    // Enemy stats
    public float getMoveSpeed()
    {
        return moveSpeed;
    }

    public float getAttackDamage()
    {
        return attackDamage;
    }

    public float getLifePoints()
    {
        return lifePoints;
    }
}
