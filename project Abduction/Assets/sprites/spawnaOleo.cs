using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnaOleo : MonoBehaviour
{
    int contador = 0;
    public GameObject[] oleo;
    Transform t;
    int chance = 70;
    int chanceB = 70;
    public GameObject barreira;
    
    const float velocidade = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        t = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // g é o objeto para o oleo que sera criado na hora
        
            //cria um range de posicoes em y que o oleo podera spawnar, para dar aleatoriedade
            
        contador++;
        //faz com que spawna o oleo apenas uma vez a cada segundo
        if(contador%200 == 0)
        {
            int r = Random.Range(1, 101);
            if (r < chance)
            {
                GameObject g;
                float posy;
                r = Random.Range(1, 4);
                if (r == 1)
                {
                    posy = -0.1f;
                }
                else if (r == 2)
                {
                    posy = -2.3f;
                }
                else
                {
                    posy = -4.6f;
                }
                Vector3 pos = new Vector3(
                    t.position.x,
                    posy,
                    0f
                );
                //pega algum dos 3 sprites de oleo que existem no jogo
                int alea = Random.Range(0, 3);
                //cria o objeto oleo, com base na prefab que lhe foi dado
                g = Instantiate(oleo[alea], pos, t.rotation);
                Rigidbody2D rb = g.GetComponent<Rigidbody2D>();
                //da velocidade ao oleo, fazendo mover para esquerda
                rb.velocity = Vector2.left * velocidade;
            }
            
        }

        if (contador % 300 == 0)
        {
            int r = Random.Range(1, 101);
            if (r < chanceB)
            {
                GameObject g;
                float posy;
                r = Random.Range(1, 4);
                if (r == 1)
                {
                    posy = -0.1f;
                }
                else if (r == 2)
                {
                    posy = -2.3f;
                }
                else
                {
                    posy = -4.6f;
                }
                Vector3 pos = new Vector3(
                    t.position.x,
                    posy,
                    0f
                );
                //pega algum dos 3 sprites de oleo que existem no jogo
                
                //cria o objeto oleo, com base na prefab que lhe foi dado
                g = Instantiate(barreira, pos, t.rotation);
                Rigidbody2D rb = g.GetComponent<Rigidbody2D>();
                //da velocidade ao oleo, fazendo mover para esquerda
                rb.velocity = Vector2.left * velocidade;
            }

        }
    }
}
