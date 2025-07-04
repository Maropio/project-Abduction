using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CutsceneStart : MonoBehaviour
{
    public PlayableDirector timeline;
    // Start is called before the first frame update
    void Start()
    {
        timeline.stopped += OnCutsceneFinished;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayCutscene()
    {
        timeline.Play();
    }

    void OnCutsceneFinished(PlayableDirector pd)
    {
        SceneManager.LoadScene("CenaCarro");
    }
}
