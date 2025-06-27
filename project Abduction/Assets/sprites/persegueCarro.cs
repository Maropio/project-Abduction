using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persegueCarro : MonoBehaviour
{
    // Start is called before the first frame update
    Transform t;
    Rigidbody2D rb;
    
    public float aceleracao = 10f;
    public float velocidadeMax = 5f;
    
    void Start()
    {
        t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 direcao = (t.position - transform.position).normalized*aceleracao;
        if (rb.velocity.magnitude > velocidadeMax)
        {
            rb.velocity = rb.velocity.normalized*velocidadeMax;
        }
        rb.AddForce(direcao,ForceMode2D.Force);
    }
}
