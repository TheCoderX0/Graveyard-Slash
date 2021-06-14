using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int enemyHealth;
    //public Animation deathAnimation;
    public GameObject Enemy;

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Instantiate(Enemy, transform.position, transform.rotation); //Instantiate(deathAnimation, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public void giveDamage(int damageToGive)
    {
        enemyHealth -= damageToGive;
    }
}
