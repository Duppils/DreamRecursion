using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : MonoBehaviour
{
    public int health;

    public void TakeDamage(int damage){
        health -= damage;
        if (health < 1){
            Die();
        }
    }

    void Die(){
        GameObject destroyTarget = transform.parent.gameObject;
        if (destroyTarget == null){
            Destroy(gameObject);
        } else {
            Destroy(destroyTarget);
        }
        
    }
}

