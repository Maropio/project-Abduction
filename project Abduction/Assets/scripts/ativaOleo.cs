using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativaOleo : MonoBehaviour
{
    // Start is called before the first frame update
    Transform transformMata;
    Transform transform;
    
    void Start()
    {
       transform = GetComponent<Transform>();
       transformMata = GameObject.FindGameObjectWithTag("mataOleo").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < transformMata.position.x)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            movimento m = collision.GetComponent<movimento>();
            m.BateOleo(60);
            
        }else if (collision.CompareTag("fusca"))
        {

        }
    }
}
