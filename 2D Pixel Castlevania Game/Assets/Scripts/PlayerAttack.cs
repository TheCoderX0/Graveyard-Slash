using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Attack Interval")]
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public float delayOfAttack = 0.25f;

    [Header("Components")]
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public Animator playerAnim;

    [Header("Damage and Range of Attack")]
    public float attackRangeX;
    public float attackRangeY;
    public int damage;

    // Update is called once per frame
    void Update()
    {
        if (timeBtwAttack <= 0)
        {
            // Then you can attack
            if (Input.GetButtonDown("Fire1"))
            {
                playerAnim.SetTrigger("attack");

                StartCoroutine(AttackDelay());

                timeBtwAttack = startTimeBtwAttack;
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(delayOfAttack);

        Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPos.position, new Vector2(attackRangeX, attackRangeY), 0, whatIsEnemies);
        for (int i = 0; i < enemiesToDamage.Length; i++)
        {
            enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(attackPos.position, new Vector3(attackRangeX, attackRangeY, 1));
    }
}
