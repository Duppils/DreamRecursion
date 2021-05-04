using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDefense : Defense
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start(){
        currentHealth = maxHealth;
    }

    public override void TakeDamage(int damage){
        currentHealth -= damage;
        if (currentHealth < 1){
            Die();
        }
    }

    void Die(){
        if (gameObject.tag == "Player"){
            Debug.Log("You Lose");
            Application.Quit();
        }
        Destroy(gameObject);
    }
}

