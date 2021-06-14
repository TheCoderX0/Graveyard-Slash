using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject EndScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EndScreen.gameObject.SetActive(true);

            Player.GetComponent<Player>().enabled = false;
            Player.GetComponent<PlayerAttack>().enabled = false;
        }
    }


}
