using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViraAlien : MonoBehaviour
{
    Transform playerTransform, alienTransform;
    // Start is called before the first frame update
    void Start()
    {
        alienTransform = GetComponent<Transform>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x - alienTransform.position.x < 0) transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (playerTransform.position.x - alienTransform.position.x > 0) transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
