using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class confirmbutton : MonoBehaviour
{
    [SerializeField] Canvas confirmationCanvas;
    [SerializeField] Canvas pausegameCanvas;

    public void YES()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    public void NO()
    {
        confirmationCanvas.gameObject.SetActive(false);
        pausegameCanvas.gameObject.SetActive(true);
    }
}
