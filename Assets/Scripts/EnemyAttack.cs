using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 5;
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player"){
            Defense defense = other.gameObject.GetComponent<Defense>();
            if (defense != null){
                defense.TakeDamage(damage=damage);
                Debug.Log(other.gameObject.name + "takes " + damage + " damage from gameObject.name");
            }
        }
    }
}
