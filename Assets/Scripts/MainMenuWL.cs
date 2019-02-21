using UnityEngine;
using System.Collections;

public class MainMenuWL : MonoBehaviour
{

    void Start()
    {
        int wins = PlayerPrefs.GetInt("PlayerWins");
        int losses = PlayerPrefs.GetInt("PlayerLosses");
        guiText.fontSize = (int)(Screen.width * 0.12f);
        guiText.text = wins.ToString() + "-" + losses.ToString();
    }

    void Update()
    {

    }
}
