using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerHurt, playerJump, enemyDamaged, enemyDead;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerHurt = Resources.Load<AudioClip>("playerHurt");
        playerJump = Resources.Load<AudioClip>("playerJump");
        enemyDamaged = Resources.Load<AudioClip>("enemyDamaged");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "playerHurt":
                audioSrc.PlayOneShot(playerHurt);
                    break;

            case "playerJump":
                audioSrc.PlayOneShot(playerJump);
                break;

            case "enemyDamaged":
                audioSrc.PlayOneShot(enemyDamaged);
                break;
        }
    }
}
