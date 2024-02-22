using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    [SerializeField] private float hp;
    private float maxHp;
    private void Start()
    {
        maxHp = hp;
    }

    public void takeDamage(float damageToBeTaken) {
        hp -= damageToBeTaken;
        if(hp<0f) {
            Destroy(gameObject);
        }
    }
}