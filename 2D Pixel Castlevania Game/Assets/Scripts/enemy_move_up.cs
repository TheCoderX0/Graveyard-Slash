using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_up : MonoBehaviour
{
    public float enemySpeed;
    public bool MoveUp;

    // Update is called once per frame
    void Update()
    {
        if (MoveUp)
        {
            transform.Translate(2 * Time.deltaTime * 0, enemySpeed, 0);
        }
        else
        {
            transform.Translate(2 * Time.deltaTime * 0, -enemySpeed, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("enemy turn Wall UP"))
        {
            if (MoveUp)
            {
                MoveUp = false;
            }
            else
            {
                MoveUp = true;
            }
        }
    }
}
