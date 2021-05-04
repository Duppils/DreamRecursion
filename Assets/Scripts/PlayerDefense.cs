using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : MonoBehaviour {
    public virtual void TakeDamage(int damage){}
}

public class PlayerDefense : Defense
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start(){
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public override void TakeDamage(int damage){
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
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

