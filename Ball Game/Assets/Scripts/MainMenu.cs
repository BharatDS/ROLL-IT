using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Canvas settingCanvas;  
    [SerializeField] Canvas mainMenuCanvas;

 
    public void Play()
    {
        SceneManager.LoadScene("LevelSelector");
    }
    
    public void loadSettingsMenu()
    {
        settingCanvas.gameObject.SetActive(true);
        mainMenuCanvas.gameObject.SetActive(false);
    }
}
