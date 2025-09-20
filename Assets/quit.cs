using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour
{
   public void quitgame()
   {
    Application.Quit();
   }
   public Image moreimg;
   public void more()
   {
      moreimg.gameObject.SetActive(true);
   }
    public void moreexit()
   {
      moreimg.gameObject.SetActive(false);
   }
}
