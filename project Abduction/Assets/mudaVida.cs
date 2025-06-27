
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mudaVida : MonoBehaviour
{
    public Image image;
    public Sprite[] sprites;
    logica logica;
    int vida = 0;
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
            if(vida == 3) image.sprite = sprites[0];
            if (vida == 2) image.sprite = sprites[1];
            if (vida == 1) image.sprite = sprites[2];
        }
    }
}
