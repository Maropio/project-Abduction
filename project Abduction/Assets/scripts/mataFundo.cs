using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mataFundo : MonoBehaviour
{
    Transform mata;
    // Start is called before the first frame update
    void Start()
    {
        mata = GameObject.FindGameObjectWithTag("mataFundo").transform;   
    }

    // Update is called once per frame
    void Update()
    {
        if (mata.transform.position.x > gameObject.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
