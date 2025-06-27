using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundoCidadeInfinito : MonoBehaviour
{
    public float velocidade = 2f;
    public float larguraDoFundo = 16f;
    public float larguraSprite = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;

        // Se saiu totalmente da tela pra esquerda, reseta pra direita
        if (transform.position.x <= -larguraSprite - 5f)
        {

            transform.position = new Vector3(larguraDoFundo,1.74f, 0);
        }
    }
}
