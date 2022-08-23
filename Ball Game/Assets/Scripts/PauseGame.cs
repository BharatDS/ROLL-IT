using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] Canvas pausemenuCanvas;
    [SerializeField] Canvas levelBaseCanvas;
    [SerializeField] Canvas confirmationCanvas;
    [SerializeField] Canvas settingsmenu;
    
    public void pauseGame()
    {
        audioSource.Stop();
        pausemenuCanvas.gameObject.SetActive(true);
        levelBaseCanvas.gameObject.SetActive(false);
        Time.timeScale=0f;
        
    }
    public void continueGame()
    {
        pausemenuCanvas.gameObject.SetActive(false);
        levelBaseCanvas.gameObject.SetActive(true);
        Time.timeScale=1f;
    } 
    public void backtoMenu()
    {
        confirmationCanvas.gameObject.SetActive(true);
        pausemenuCanvas.gameObject.SetActive(false);
    }
    public void open_settings()
    {
        settingsmenu.gameObject.SetActive(true);
        pausemenuCanvas.gameObject.SetActive(false);
    }
    public void RETRY()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1f;
    }
}
