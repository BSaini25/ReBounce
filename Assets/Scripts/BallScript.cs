using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    public float speed = 2.0f;
    public static int playerscore = 0;
    public static int cpuscore = 0;
    public static int playerwins = 0;
    public static int playerlosses = 0;
    public AudioClip impact;
    public AudioClip score;

    void Start()
    {
        rigidbody2D.velocity = Vector2.one.normalized * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                    float racketHeight)
    {
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RacketLeft")
        {
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;

            rigidbody2D.velocity = dir * speed;

            audio.PlayOneShot(impact, 0.7F);
        }

        if (col.gameObject.name == "RacketRight")
        {
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            rigidbody2D.velocity = dir * speed;

            audio.PlayOneShot(impact, 0.7F);
        }

        if (col.gameObject.tag == "WallBottom")
        {
            audio.PlayOneShot(impact, 0.7F);
        }
        if (col.gameObject.tag == "WallTop")
        {
            audio.PlayOneShot(impact, 0.7F);
        }

        if (col.gameObject.tag == "WallLeft")
        {
            cpuscore++;
            audio.PlayOneShot(score, 0.7F);
        }

        if (col.gameObject.tag == "WallRight")
        {
            playerscore++;
            audio.PlayOneShot(score, 0.7F);
        }

        if (playerscore == 10)
        {
            playerscore = 0;
            cpuscore = 0;
            playerwins++;
            PlayerPrefs.SetInt("PlayerWins", playerwins);
            UnityEngine.Application.LoadLevel("Win");
        }
        else if (cpuscore == 10)
        {
            playerscore = 0;
            cpuscore = 0;
            playerlosses++;
            PlayerPrefs.SetInt("PlayerLosses", playerlosses);
            UnityEngine.Application.LoadLevel("Lose");
        }
    }
}