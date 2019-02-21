using UnityEngine;
using System.Collections;

public class AIScript : MonoBehaviour
{
    Transform ball;
    Transform ai;
    public float AISpeed = 0.19f;

    void Start()
    {
        ball = GameObject.FindWithTag("Ball").transform;
        ai = GameObject.FindWithTag("AI").transform;
    }

    void FixedUpdate()
    {
        float ballAIdiff = ball.position.y - ai.position.y;
        float AIballdiff = ai.position.y - ball.position.y;

        if (ball.position.y > ai.position.y)
        {
            transform.Translate(new Vector2(0.0f, ballAIdiff * AISpeed));
        }
        else if (ball.position.y < ai.position.y)
        {
            transform.Translate(new Vector2(0.0f, -AIballdiff * AISpeed));
        }
    }

}
