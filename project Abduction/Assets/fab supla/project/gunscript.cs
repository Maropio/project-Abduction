using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunscript : MonoBehaviour
{

    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileSpeed = 10f;
    public float fireRate = 0.3f;

    private float nextFireTime = 0f;

    public Animator gunAnimator;
    public SpriteRenderer playerSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;

            // Disparar a animação da arma (se existir)
            if (gunAnimator != null)
            {
                gunAnimator.SetTrigger("Shoot");
            }

            // Instanciar o projetil
            if (projectilePrefab != null && firePoint != null)
            {
                GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);

                // Verifica se o projetil ainda existe antes de acessar seus componentes
                if (projectile != null)
                {
                    // Define direção com base no flipX
                    Vector2 direction = playerSpriteRenderer.flipX ? Vector2.left : Vector2.right;

                    // Aplica velocidade ao Rigidbody
                    Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
                    if (rb != null)
                    {
                        rb.velocity = direction * projectileSpeed;
                    }

                    // Se tiver sprite renderer no projétil, vira também
                    SpriteRenderer projSprite = projectile.GetComponent<SpriteRenderer>();
                    if (projSprite != null)
                    {
                        projSprite.flipX = playerSpriteRenderer.flipX;
                    }
                }
            }
        }
    }

}

   




