using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Essencial para trabalhar com UI!

public class VidaFusca : MonoBehaviour
{
    // --- Vari�veis de Vida ---
    
    private int currentHealth;

    // --- Refer�ncias da UI (arrastar no Inspector) ---
    [SerializeField] private GameObject heartPrefab; // Nosso prefab do cora��o
    [SerializeField] private Transform healthContainer; // O objeto com o Horizontal Layout Group

    void Start()
    {
        currentHealth = logica.GetVidasFusca();
        UpdateHealthUI();
    }

    


    // A M�GICA ACONTECE AQUI!
    public void UpdateHealthUI()
    {
        // 1. Limpa todos os cora��es antigos para n�o duplicar
        foreach (Transform child in healthContainer)
        {
            Destroy(child.gameObject);
        }

        // 2. Cria um cora��o novo para cada ponto de vida atual
        for (int i = 0; i < currentHealth; i++)
        {
            // "Instantiate" cria uma c�pia do nosso prefab.
            // O segundo argumento (healthContainer) faz com que o novo cora��o
            // seja criado como "filho" do nosso container, e o Horizontal Layout Group
            // j� cuida de posicionar ele pra gente!
            Instantiate(heartPrefab, healthContainer);
        }
    }

    // --- Fun��es de Teste (pode apagar depois) ---
    void Update()
    {
        if (currentHealth != logica.GetVidasFusca())
        {
            currentHealth = logica.GetVidasFusca();
            UpdateHealthUI();
        }
    }
}