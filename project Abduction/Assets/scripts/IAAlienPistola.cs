using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IAAlienPistola : MonoBehaviour
{
    Rigidbody2D rb;
    Transform alienTransform;
    Transform playerTransform;
    bool estaLonge = false;
    float aceleracao = 15f;
    float velocidadeMax = 5f;
    int vida = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        alienTransform = GetComponent<Transform>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector2.Distance(alienTransform.position, playerTransform.position);

        if (distancia > 15)
        {
            estaLonge = true;
        }

        if (estaLonge)
        {
            Vector3 direcao = (playerTransform.position - alienTransform.position).normalized * aceleracao;

            rb.AddForce(direcao);

            if (rb.velocity.sqrMagnitude > velocidadeMax * velocidadeMax)
            {
                rb.velocity = rb.velocity.normalized * velocidadeMax;
            }

            if (distancia < 11)
            {
                estaLonge = false;
                rb.velocity = Vector2.zero;
            }
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("projetil"))
        {
            vida--;
            Destroy(collision.gameObject);
        }
        if(vida == 0)
        {
            SpawnaAlien.DecrementaAlien();
            Destroy(gameObject);
        }
    }
}
