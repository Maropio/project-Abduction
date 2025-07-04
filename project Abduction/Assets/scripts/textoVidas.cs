using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textoVidas : MonoBehaviour
{
    int vida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida != logicaLevel2.GetVidas())
        {
            vida = logicaLevel2.GetVidas();
            gameObject.GetComponent<TextMeshProUGUI>().text = "Vidas: " + vida;
        }
    }
}
