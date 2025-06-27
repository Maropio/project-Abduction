using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidade = 7.5f;
    Vector2 input;
    bool bateuOleo = false;
    int contador= 0;
    int tempo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //esta linha cria na variável input, um vetor de valor -1,0 ou 1 dependendo do Input do jogador
        if (logica.GetVidas() > 0){
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
    }

    void FixedUpdate()
    {
        //aqui apenas adicionamos o valor do input (que sera sempre 1,-1 ou zero) * velocidade 
        //a variavel de velocidade do rigibody
        if (bateuOleo)
        {

            Vector2 direcao = rb.velocity;
            rb.velocity = direcao;
            contador++;
            if (contador > tempo)
            {
                bateuOleo=false;
                contador = 0;
            }
        }
        else
        {
            rb.velocity = input * velocidade;
        }
           
    }
    
    public void BateOleo(int tempo)
    {
        if(rb.velocity.magnitude !=0)
        {
            bateuOleo = true;
            this.tempo = tempo;
        }
        
    }
}
