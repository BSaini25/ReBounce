using UnityEngine;
using System.Collections;

public class WinLoss : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        guiText.fontSize = (int)(Screen.width * 0.15f);
        if (Input.touchCount > 0)
        {
            Application.LoadLevel("MainMenu");
        }

        if (Input.anyKey)
        {
            Application.LoadLevel("MainMenu");
        }
    }
}
