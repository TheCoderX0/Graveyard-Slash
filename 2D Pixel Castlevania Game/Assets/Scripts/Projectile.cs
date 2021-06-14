using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public CharacterController player;
    private Rigidbody2D rb2D;
    public float rotationSpeed;
    public int damageToGive;
    //public GameObject fireBall;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharacterController>();
        rb2D = GetComponent<Rigidbody2D>();

        if (player.transform.position.x < transform.position.x)
        {
            speed = -speed;
            rotationSpeed = -rotationSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(speed, rb2D.velocity.y);
        rb2D.angularVelocity = rotationSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            HealthManager.HurtPlayer(damageToGive);
        }

        //Instantiate (fireBall, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
