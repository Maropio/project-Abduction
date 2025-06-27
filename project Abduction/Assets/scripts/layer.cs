using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layer : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sr;
    Transform transform;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        sr.sortingOrder = Mathf.RoundToInt(-transform.position.y*100);
    }
}
