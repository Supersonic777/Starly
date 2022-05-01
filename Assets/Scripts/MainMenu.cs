using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private bool paused;
    // Start is called before the first frame update
    public void gameIsPaused()
    {
      if(paused)
      {
        Resume();
      }
      else
      {
        Pause();
      }
    }
    void Pause()
    {
       Time.timeScale = 0f;
       paused = true;
    }
    void Resume()
    {
       Time.timeScale = 1f;
       paused = false;
    }
}
