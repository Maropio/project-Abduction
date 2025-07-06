using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutsceneInicial : MonoBehaviour
{
    [Header("Configurações da Cutscene")]
    [SerializeField] private AudioClip narrationClip; // O áudio que vai tocar
    [SerializeField] private string sceneNameToLoad; // O nome da cena para carregar depois
    private bool sceneIsLoading = false;
    private AudioSource myAudioSource;

    void Start()
    {
        // Pega o componente AudioSource que está no mesmo objeto
        myAudioSource = GetComponent<AudioSource>();

        // Inicia a nossa rotina "mágica"
        StartCoroutine(PlayAudioAndLoadScene());
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextScene();
        }
    }
    // Corrotinas são do tipo IEnumerator
    private IEnumerator PlayAudioAndLoadScene()
    {
        // 1. Toca o nosso clipe de áudio
        // Usamos PlayOneShot para garantir que ele toque do início ao fim
        myAudioSource.PlayOneShot(narrationClip);

        // Mensagem de debug para sabermos que a corrotina começou
        Debug.Log("Iniciando narração...");

        // 2. A MÁGICA: Espera o áudio acabar
        // 'yield return' pausa a corrotina aqui.
        // 'WaitWhile' faz ela esperar ENQUANTO a condição for verdadeira.
        // Ou seja, a corrotina fica pausada nesta linha enquanto o áudio estiver tocando.
        yield return new WaitWhile(() => myAudioSource.isPlaying);

        // Quando myAudioSource.isPlaying se torna 'false', a corrotina continua daqui.
        Debug.Log("Áudio terminou, carregando a próxima cena...");

        // 3. Carrega a nova cena
        SceneManager.LoadScene(sceneNameToLoad);
    }
    private void LoadNextScene()
    {
        // Se a "bandeira" já foi levantada, significa que já estamos carregando.
        // O 'return' para a execução da função aqui mesmo.
        if (sceneIsLoading)
        {
            return;
        }

        // Se chegamos aqui, significa que é a primeira vez.
        // Levantamos a bandeira para que nenhuma outra chamada funcione.
        sceneIsLoading = true;

        // É uma boa prática parar todas as corrotinas neste objeto
        // antes de carregar uma nova cena para garantir que nada mais execute.
        StopAllCoroutines();

        Debug.Log("Carregando cena: " + sceneNameToLoad);
        SceneManager.LoadScene(sceneNameToLoad);
    }
}

