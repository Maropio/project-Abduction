
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnaAlien : MonoBehaviour
{
    int contador = 0, maxAliens,spawnCooldown,horda = 0;
    static int totalAliens = 0,totalAliensSpawnados =0;
    const int chance = 70;
    public GameObject[] aliens;
    public Transform[] t;
    float alea = 1;


    void Start()
    {
        maxAliens = logicaLevel2.MaxInimigosHorda();
        spawnCooldown = logicaLevel2.SpawnCooldown();
    }

    // Update is called once per frame
    

    private void FixedUpdate()
    {
        
        if(horda != logicaLevel2.GetHorda())
        {
            horda = logicaLevel2.GetHorda();
            maxAliens = logicaLevel2.MaxInimigosHorda();
            spawnCooldown = logicaLevel2.SpawnCooldown();
            totalAliens = 0;
            totalAliensSpawnados = 0;
        }
        if(totalAliensSpawnados < maxAliens)
        {
            if (contador % (int)(spawnCooldown *alea+1) == 0)
            {
                int c = Random.Range(1, 101);
                if (c <= chance)
                {
                    int r = Random.Range(0, t.Length);
                    GameObject alien = Instantiate(aliens[0], t[r].position, Quaternion.identity);
                    alien.transform.position = new Vector3(alien.transform.position.x, alien.transform.position.y, 0f);
                    totalAliens += 1;
                    totalAliensSpawnados++;
                }
                else
                {
                    int r = Random.Range(0, 6);
                    GameObject alien = Instantiate(aliens[1], t[r].position, Quaternion.identity);
                    alien.transform.position = new Vector3(alien.transform.position.x, alien.transform.position.y, 0f);
                    totalAliens += 1;
                    totalAliensSpawnados++;
                }
            }
            contador++;
            alea = Random.Range(0.8f, 1.3f);
        }
        if (totalAliens == 0 && totalAliensSpawnados == maxAliens)
        {
            logicaLevel2.AumentaHorda();
        }
    }
    public static void DecrementaAlien()
    {
        totalAliens--;
    }
}
