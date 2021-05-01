using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public float duration = 1f;
    public Rigidbody2D rb;
    public string sourceTag;
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, duration);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        string otherTag = other.gameObject.tag;
        if ((otherTag != sourceTag) & (otherTag != gameObject.tag)){
            Debug.Log("Hit: " + other.name);
            Defense defense = other.GetComponent<Defense>();
            if (defense != null){
                defense.TakeDamage(damage=damage);
                Debug.Log(other.name + "takes " + damage + " damage.");
            }
            Destroy(gameObject);
        }
    }

}
