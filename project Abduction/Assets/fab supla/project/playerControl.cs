using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    [Header("Movimentação")]
    public float movSpeed;
    private float speedX, speedY;
    private Rigidbody2D rb;

    [Header("Referências")]
    public Animator animator;
    private SpriteRenderer spriteRenderer;

    [Header("Pistola")]
    public Transform gunHolder;
    public Animator gunAnimator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Leitura de input
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.velocity = new Vector2(speedX, speedY);

        // Flip horizontal e escala do braço
        if (speedX > 0)
        {
            spriteRenderer.flipX = false;
            gunHolder.localScale = new Vector3(1, 1, 1);
        }
        else if (speedX < 0)
        {
            spriteRenderer.flipX = true;
            gunHolder.localScale = new Vector3(-1, 1, 1);
        }

        // Detecta movimento
        bool isRunning = (speedX != 0 || speedY != 0);

        // Atualiza o Animator
        animator.SetBool("isRunning", isRunning);


       

    }
}
