using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatePlayer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            logica.PerdeVidas(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            logica.PerdeVidas(1);
        }

        if (collision.gameObject.CompareTag("Fusca"))
        {
            logica.PerdeVidasFusca();
        }
    }
}
