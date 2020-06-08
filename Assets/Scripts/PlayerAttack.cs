using System.Collections;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;

    public float startTimeBtwAttack;
    public float attackRange;

    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public GameObject fire;


    private void Update()
    {
        if(timeBtwAttack <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                timeBtwAttack = startTimeBtwAttack;
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    private void Attack()
    {
        animator.SetTrigger("Attack");
        StartCoroutine("Fire");
        //Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        /*foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("Hit " + enemy.name);
            enemy.GetComponent<Explodable>().explode();
        }*/

    }

    /*private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawSphere(attackPoint.position, attackRange);
    }*/

    private IEnumerator Fire()
    {
        yield return new WaitForSeconds(0.3f);
        Instantiate(fire, attackPoint.position, fire.transform.rotation);
    }
}