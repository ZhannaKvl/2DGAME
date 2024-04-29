using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLava : MonoBehaviour
{
    public AudioClip impactSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(impactSound, transform.position);
            ResetBallPosition();
        }
    }

    private void ResetBallPosition()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Player");

        if (ball != null)
        {
            ball.transform.position = Vector3.zero;
        }
        else
        {
            Debug.LogWarning("Ball not found!");
        }
    }
}
