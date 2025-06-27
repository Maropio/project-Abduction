using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundoInfinito : MonoBehaviour
{
    public float velocidade;
    
    private float comprimentoFundo, posInicial;


    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position.x;
        comprimentoFundo = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;
        if (posInicial - transform.position.x > comprimentoFundo)
        {
            transform.position = new Vector3(posInicial, transform.position.y, transform.position.z);
        }

    }
    private void FixedUpdate()
    {
        
        // Se saiu totalmente da tela pra esquerda, reseta pra direita
        
    }
}
  