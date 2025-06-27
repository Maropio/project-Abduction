using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textoHorda : MonoBehaviour
{
    int horda;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(horda != logicaLevel2.GetHorda())
        {
            horda = logicaLevel2.GetHorda();
            gameObject.GetComponent<TextMeshProUGUI>().text = "Horda: "+horda;
        }
    }
}
