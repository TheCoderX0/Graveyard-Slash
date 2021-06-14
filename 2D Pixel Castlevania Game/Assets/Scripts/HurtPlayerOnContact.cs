using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayerOnContact : MonoBehaviour
{
    public int damageToGive;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            HealthManager.HurtPlayer(damageToGive);

            var player = other.GetComponent<Player>();
            player.KnockbackCount = player.KnockbackLenght;

            if (other.transform.position.x < transform.position.x)
            {
                player.KnockFromRight = true;
            }
            else
            {
                player.KnockFromRight = false;
            }
        }
    }

}
