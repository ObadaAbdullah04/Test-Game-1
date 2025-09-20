using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
  public GameObject pausemenuu;
  
  public void pausebutton()
  {
    pausemenuu.SetActive(true);
    Time.timeScale = 0f ;
    
  }

  public void playbutton()
  {
    pausemenuu.SetActive(false);
    Time.timeScale = 1f ;
    
  }
  
  public void Home(int SceneID)
  {
    Time.timeScale = 1f ;
    SceneManager.LoadScene(SceneID);
  }
}
