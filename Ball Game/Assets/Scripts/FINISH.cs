using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class FINISH : MonoBehaviour
{
    [SerializeField] Canvas levelBaseCanvas;
    [SerializeField] Canvas levelCompleteCanvas;
    [SerializeField] GameObject playerBall;
    [SerializeField] float y;
    FINISH[] finishes;
    public bool levelComplete = false;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "BALL")
        {
            levelBaseCanvas.gameObject.SetActive(false);
            levelCompleteCanvas.gameObject.SetActive(true);
            runlevelComplete();
        }
    }

    void runlevelComplete()
    { 
        int i = 0;
        finishes = FindObjectsOfType<FINISH>();
        while(finishes[i] != null)
        {
            finishes[i].levelComplete = true;
            i++;
        }
        
    }

    private void Update() 
    {
        if(playerBall.transform.position.y < y && levelComplete == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
