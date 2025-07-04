using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Essencial para trabalhar com UI!

public class VidaFusca : MonoBehaviour
{
    // --- Variáveis de Vida ---
    
    private int currentHealth;

    // --- Referências da UI (arrastar no Inspector) ---
    [SerializeField] private GameObject heartPrefab; // Nosso prefab do coração
    [SerializeField] private Transform healthContainer; // O objeto com o Horizontal Layout Group

    void Start()
    {
        currentHealth = logica.GetVidasFusca();
        UpdateHealthUI();
    }

    


    // A MÁGICA ACONTECE AQUI!
    public void UpdateHealthUI()
    {
        // 1. Limpa todos os corações antigos para não duplicar
        foreach (Transform child in healthContainer)
        {
            Destroy(child.gameObject);
        }

        // 2. Cria um coração novo para cada ponto de vida atual
        for (int i = 0; i < currentHealth; i++)
        {
            // "Instantiate" cria uma cópia do nosso prefab.
            // O segundo argumento (healthContainer) faz com que o novo coração
            // seja criado como "filho" do nosso container, e o Horizontal Layout Group
            // já cuida de posicionar ele pra gente!
            Instantiate(heartPrefab, healthContainer);
        }
    }

    // --- Funções de Teste (pode apagar depois) ---
    void Update()
    {
        if (currentHealth != logica.GetVidasFusca())
        {
            currentHealth = logica.GetVidasFusca();
            UpdateHealthUI();
        }
    }
}