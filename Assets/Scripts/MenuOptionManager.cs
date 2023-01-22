using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptionManager : MonoBehaviour
{
    
    public AudioSource audioSource;

    public void LoadGame()
    {
        SceneManager.LoadScene(0);
    }
    public void loadAbout(){    
        SceneManager.LoadScene(4);
    }
    public void loadExit(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
    public void Instructions(){
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }

    }
}
