using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MudaTexto : MonoBehaviour
{
    int vida;
    string text = "Vidas = ";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vida != logica.GetVidas())
        {
            vida = logica.GetVidas();
            gameObject.GetComponent<TextMeshProUGUI>().text = text + vida;
        }
    }


}
