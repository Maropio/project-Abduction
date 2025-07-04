using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class MudaVida2 : MonoBehaviour
{
    public Image image;
    public Sprite[] sprites;
    
    int vida = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (vida != logicaLevel2.GetVidas())
        {
            vida = logicaLevel2.GetVidas();
            if (vida == 3) image.sprite = sprites[0];
            if (vida == 2) image.sprite = sprites[1];
            if (vida == 1) image.sprite = sprites[2];
        }
    }

}
