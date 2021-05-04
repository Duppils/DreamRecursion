using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireCooldown = 0.2f;
    public Camera cam;
    public Rigidbody2D rb;
    Vector2 mousePos;
    bool fireOffCooldown = true;

    void FixedUpdate()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetButton("Fire1"))
        {
            StartCoroutine(Shoot());
        }

    }

    IEnumerator Shoot()
    {
        if (fireOffCooldown){
            fireOffCooldown = false;
            Vector2 lookDirection = mousePos - rb.position;
            float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
            Quaternion target = Quaternion.Euler(0, 0, angle);
            Instantiate(bulletPrefab, firePoint.position, target);
            yield return new WaitForSeconds(fireCooldown);
            fireOffCooldown = true;
        }
    }
}
