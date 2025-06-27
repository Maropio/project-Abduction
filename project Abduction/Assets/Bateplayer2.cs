using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateplayer2 : MonoBehaviour
{

    int vida = 3;
    public bool isAlien;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            logicaLevel2.PerdeVidas(1);
            if(!isAlien) Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAlien)
        {
            if (collision.CompareTag("projetil"))
            {
                vida--;
                Destroy(collision.gameObject);

            }
            if (vida == 0)
            {
                SpawnaAlien.DecrementaAlien();
                Destroy(gameObject);
            }
        }
        
    }
}
