using UnityEngine;
using System.Collections;

public class AIScoreGUI : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        int aiscore = BallScript.cpuscore;
        guiText.text = aiscore.ToString();
    }
}