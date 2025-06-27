using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectinstanc : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;

    [Range(0f, 180f)]
    public float maxRotationAngle = 60f; // Limite de rotação a partir da direita (0°)


    // Start is called before the first frame update
    void Start()
    {
        if (firePoint == null)
        {
            firePoint = transform.Find("FirePoint");
        }
    }

    // Update is called once per frame
    void Update()
    {
        RotateGunTowardsMouse();

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

    }

    void RotateGunTowardsMouse()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseWorldPos - transform.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Limita o ângulo entre -maxRotationAngle e +maxRotationAngle
        angle = Mathf.Clamp(angle, -maxRotationAngle, maxRotationAngle);

        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    void Fire()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseWorldPos - firePoint.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Bloqueia o tiro se estiver fora do ângulo permitido
        if (angle < -maxRotationAngle || angle > maxRotationAngle)
            return;

        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.velocity = direction * projectileSpeed;
    }
}

    

