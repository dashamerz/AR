using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audio : MonoBehaviour
{
    AudioSource music;
    public Button runButton, stopButton, backButton;
    

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        runButton.onClick.AddListener(Run);
        stopButton.onClick.AddListener(RunBack);
        backButton.onClick.AddListener(Back);

    }

    void Run()
    {
        music.Play();
    }
    void RunBack()
    {
        music.Stop();
    }
    void Back()
    {
        music.Stop();
    }
}
