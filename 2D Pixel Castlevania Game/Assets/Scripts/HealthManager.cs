using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxPlayerHealth;
    public static int playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxPlayerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public static void HurtPlayer(int damageToGive)
    {
        SoundManager.PlaySound("playerHurt");
        playerHealth -= damageToGive;
    }

    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
    }
}
