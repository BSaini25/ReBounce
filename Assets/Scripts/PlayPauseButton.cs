using UnityEngine;
using System.Collections;

public class PlayPauseButton : TouchManager
{
    public enum button { Pause, Play };
    public button buttonType;

    void Update()
    {
        TouchInput();
    }

    void OnFirstTouch()
    {
        if (buttonType == button.Pause)
        {
            Time.timeScale = 0;
        }
        else if (buttonType == button.Play)
        {
            Time.timeScale = 1;
        }
    }
}
