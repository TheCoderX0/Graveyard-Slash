using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayerInRange : MonoBehaviour
{
    public Player player;
    public GameObject fireball;
    public Transform launchPoint;

    public float playerRange;
    public float waitBetweenShots;
    private float shotCounter;
    public float delayOfEnemyAttack;

    public Animator enemyAnim;

    // Start is called before the first frame update
    void Start()
    {
        enemyAnim = GetComponent<Animator>();
        player = FindObjectOfType<Player>();
        shotCounter = waitBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));
        shotCounter -= Time.deltaTime;

        if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && shotCounter < 0)
        {
            enemyAnim.SetTrigger("EnemyAttack1");
            StartCoroutine(EnemyDelay());

            shotCounter = waitBetweenShots;
        }

        if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && shotCounter < 0)
        {
            enemyAnim.SetTrigger("EnemyAttack1");
            StartCoroutine(EnemyDelay());

            shotCounter = waitBetweenShots;
        }
    }

    IEnumerator EnemyDelay()
    {
        yield return new WaitForSeconds(delayOfEnemyAttack);
        Instantiate(fireball, launchPoint.position, launchPoint.rotation);
    }
}
