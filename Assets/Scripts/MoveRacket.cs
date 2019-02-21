using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;

    void FixedUpdate()
    {
        if (Input.GetKey(up))
        {
            transform.Translate(new Vector2(0.0f, 0.18f));
        }

        if (Input.GetKey(down))
        {
            transform.Translate(new Vector2(0.0f, -0.18f));
        }

        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            if ((touch.position.x < Screen.width / 2) & (touch.position.y > Screen.height / 2))
            {
                transform.Translate(new Vector2(0.0f, 0.15f));
            }
            else if ((touch.position.x < Screen.width / 2) & (touch.position.y < Screen.height / 2))
            {
                transform.Translate(new Vector2(0.0f, -0.15f));
            }
        }
    }
}