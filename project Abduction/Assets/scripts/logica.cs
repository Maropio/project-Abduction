using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using Unity.Mathematics;
using System;
using Unity.VisualScripting;


public class logica : MonoBehaviour
{
    private static int vidas, invincibilidade = 0,vidaFusca; 
    static TextMeshProUGUI vidasTxt,tempoTXT;
    static Cenas cena = new Cenas();

    void Start()
    {
        vidas = 3;
        vidaFusca = 6;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            vidas++;
        }
        
    }
    public static int GetVidas()
    {
        return vidas;
    }
    public static void PerdeVidas(int q)
    {
        if (invincibilidade == 0)
        {
            vidas -= q;
            //vidasTxt.text = "vidas: " + vidas.ToString();
            invincibilidade = 60;
        }
        if (vidas == 0)
        {
            cena.CarregaCena("Main Menu");
        }
    }
    public void FixedUpdate()
    {
        if (invincibilidade > 0)
        {
            invincibilidade--;
        }
    }

    public static void PerdeVidasFusca()
    {
        vidaFusca--;
        if(vidaFusca == 0)
        {
            SceneManager.LoadScene("CenaSupla");
        }
    }

    public static int GetVidasFusca()
    {
        return vidaFusca;
    }


}
