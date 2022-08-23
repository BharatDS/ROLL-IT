using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] Slider x_sensitivity;
    [SerializeField] Slider y_sensitivity;
    [SerializeField] Slider volume;
    [SerializeField] Canvas settingCanvas;  
    [SerializeField] Canvas pause_or_main_MenuCanvas;
    [SerializeField] public float x;
    [SerializeField] public float y;
    [SerializeField] public float v;

    
    private void Start() 
    {
        x_sensitivity.value = PlayerPrefs.GetFloat("Xsensitivity",0.5f);
        y_sensitivity.value = PlayerPrefs.GetFloat("Ysensitivity",0.5f);
        volume.value = PlayerPrefs.GetFloat("Volume",1f);
    }
    public void BackToMenu()
    {
        settingCanvas.gameObject.SetActive(false);
        pause_or_main_MenuCanvas.gameObject.SetActive(true);
        
    }
    
   public void manageX_sensitivity()
   {
       PlayerPrefs.SetFloat("Xsensitivity", x_sensitivity.value);
   }
   public void manageY_sensitivity()
   {
       PlayerPrefs.SetFloat("Ysensitivity", y_sensitivity.value);
   }
   public void manageVolume()
   {
       PlayerPrefs.SetFloat("Volume", volume.value);
       AudioListener.volume = PlayerPrefs.GetFloat("Volume",1f);
   }
  
   void Update() {

       x = PlayerPrefs.GetFloat("Xsensitivity",0.5f);
        y= PlayerPrefs.GetFloat("Ysensitivity",0.5f);
        v = PlayerPrefs.GetFloat("Volume",1f);
   }
}
