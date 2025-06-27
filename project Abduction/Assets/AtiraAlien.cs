using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class AtiraAlien : MonoBehaviour
{
    public GameObject tiro;
    public Transform pontoarma;
    Transform player;
    public float velocidade;
    int contador = 0;
    public int fireRate;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Atira();
    }
    public void Atira()
    {
        if (contador % fireRate == 0)
        {
            
            
            GameObject t = Instantiate(tiro, gameObject.transform.position,quaternion.identity);
            Rigidbody2D rb = t.GetComponent<Rigidbody2D>();
            
            if (player.position.x - gameObject.transform.position.x > 0)
            {
                rb.velocity = Vector2.right * velocidade;
            }
            else
            {
                rb.velocity = Vector2.left * velocidade;
            }
        }
        contador++;


    }
}
