using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutsceneInicial : MonoBehaviour
{
    [Header("Configura��es da Cutscene")]
    [SerializeField] private AudioClip narrationClip; // O �udio que vai tocar
    [SerializeField] private string sceneNameToLoad; // O nome da cena para carregar depois
    private bool sceneIsLoading = false;
    private AudioSource myAudioSource;

    void Start()
    {
        // Pega o componente AudioSource que est� no mesmo objeto
        myAudioSource = GetComponent<AudioSource>();

        // Inicia a nossa rotina "m�gica"
        StartCoroutine(PlayAudioAndLoadScene());
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextScene();
        }
    }
    // Corrotinas s�o do tipo IEnumerator
    private IEnumerator PlayAudioAndLoadScene()
    {
        // 1. Toca o nosso clipe de �udio
        // Usamos PlayOneShot para garantir que ele toque do in�cio ao fim
        myAudioSource.PlayOneShot(narrationClip);

        // Mensagem de debug para sabermos que a corrotina come�ou
        Debug.Log("Iniciando narra��o...");

        // 2. A M�GICA: Espera o �udio acabar
        // 'yield return' pausa a corrotina aqui.
        // 'WaitWhile' faz ela esperar ENQUANTO a condi��o for verdadeira.
        // Ou seja, a corrotina fica pausada nesta linha enquanto o �udio estiver tocando.
        yield return new WaitWhile(() => myAudioSource.isPlaying);

        // Quando myAudioSource.isPlaying se torna 'false', a corrotina continua daqui.
        Debug.Log("�udio terminou, carregando a pr�xima cena...");

        // 3. Carrega a nova cena
        SceneManager.LoadScene(sceneNameToLoad);
    }
    private void LoadNextScene()
    {
        // Se a "bandeira" j� foi levantada, significa que j� estamos carregando.
        // O 'return' para a execu��o da fun��o aqui mesmo.
        if (sceneIsLoading)
        {
            return;
        }

        // Se chegamos aqui, significa que � a primeira vez.
        // Levantamos a bandeira para que nenhuma outra chamada funcione.
        sceneIsLoading = true;

        // � uma boa pr�tica parar todas as corrotinas neste objeto
        // antes de carregar uma nova cena para garantir que nada mais execute.
        StopAllCoroutines();

        Debug.Log("Carregando cena: " + sceneNameToLoad);
        SceneManager.LoadScene(sceneNameToLoad);
    }
}

