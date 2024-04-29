using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicWin : MonoBehaviour
{
    public AudioClip impactSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(impactSound, transform.position);
        }
    }
}
