using UnityEngine;
using System.Collections;

public class LevelLoad : TouchManager
{
    public enum button { Easy, Medium, Hard };
    public button buttonType;

    void Update ()
    {
        TouchInput();
    }

    void OnFirstTouch()
    {
        if (buttonType == button.Easy)
        {
            Application.LoadLevel("Easy");
        }
        else if (buttonType == button.Medium)
        {
            Application.LoadLevel("Medium");
        }
        else if (buttonType == button.Hard)
        {
            Application.LoadLevel("Hard");
        }
    }
}
