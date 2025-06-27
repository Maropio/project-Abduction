using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour
{
    public void CarregaCena(string cena)
    {
        SceneManager.LoadScene(cena);

    }

    public void FechaJogo()
    {
        Application.Quit();
    }
}
