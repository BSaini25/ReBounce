using UnityEngine;
using System.Collections;

public class PlayerScoreGUI : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        int playerscore = BallScript.playerscore;
        guiText.text = playerscore.ToString();
    }
}
