using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Camera cam;
    public Rigidbody2D rb;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        Quaternion target = Quaternion.Euler(0, 0, angle);
        Instantiate(bulletPrefab, firePoint.position, target);
    }
}
