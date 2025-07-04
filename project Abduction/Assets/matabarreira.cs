using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matabarreira : MonoBehaviour
{
    // Start is called before the first frame update
    Transform transformMata;
    void Start()
    {
        transformMata = GameObject.FindGameObjectWithTag("mataOleo").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < transformMata.position.x)
        {
            Destroy(gameObject);
        }
    }
}
