using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Cutscene2 : MonoBehaviour
{
    int conta = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if(conta%300 == 0)
        {
            SceneManager.LoadScene("CenaSupla");
        }
        conta++;
    }
}
