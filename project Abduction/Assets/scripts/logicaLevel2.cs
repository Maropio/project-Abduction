using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;


public class logicaLevel2 : MonoBehaviour
{
    static int horda, maxAliens,vidas, invincibilidade =0,aliensVivos;
    static int spawnCooldown = 5;
    // Start is called before the first frame update
    void Start()
    {
        horda = 1;
        vidas = 3;
        maxAliens = MaxInimigosHorda();
        spawnCooldown = SpawnCooldown();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (invincibilidade>0)
        {
            invincibilidade--;
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) horda++;
    }

    public static int GetVidas()
    {
        return vidas;
    }
    public static void PerdeVidas(int n)
    {
        if(invincibilidade == 0)
        {
            vidas -= n;
            invincibilidade = 120;
        }
        if (vidas == 0)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    public static int GetHorda()
    {
        return horda;
    }
    public static int MaxInimigosHorda()
    {
       
        int max = (int)((horda-1) * 1.5f* UnityEngine.Random.Range(0.8f,1.2f) + 10  );

        return max;
    }
    public static int SpawnCooldown()
    {
        spawnCooldown = (int)(240f*(float)math.pow(0.8,horda-1));
        return (int)spawnCooldown;
    }
    public static void AumentaHorda()
    {
        horda++;
        
    }
}
