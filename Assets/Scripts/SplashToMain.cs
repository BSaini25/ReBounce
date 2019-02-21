using UnityEngine;
using System.Collections;

public class SplashToMain : MonoBehaviour
{
    float time = 0;

    void Start()
    {
        time = 2;
    }


    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            UnityEngine.Application.LoadLevel("MainMenu");
        }
    }
}