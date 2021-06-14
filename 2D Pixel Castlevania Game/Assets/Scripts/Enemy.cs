using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public float speed;
    private float dazedTime;
    public float startDazedTime;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dazedTime <= 0)
        {
            speed = 5;
        }
        else
        {
            speed = 0;
            dazedTime -= Time.deltaTime;
        }

        if (health <= 0)
        {

            Destroy(GetComponent<enemy_move>());
            Destroy(GetComponent<enemy_move_up>());
            Destroy(GetComponent<ShootAtPlayerInRange>());

            GetComponent<Collider2D>().enabled = false;

            anim.SetBool("IsDead", true);

            Destroy(gameObject, 0.45f);
        }
    }

    public void TakeDamage(int damage)
    {
        SoundManager.PlaySound("enemyDamaged");

        dazedTime = startDazedTime;

        health -= damage;
        Debug.Log("damage TAKEN!");
    }
}
