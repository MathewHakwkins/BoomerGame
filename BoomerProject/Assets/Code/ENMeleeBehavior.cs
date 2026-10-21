using UnityEngine;
using UnityEngine.AI;

public class ENMeleeBehavior : MonoBehaviour
{

    public GameObject target;
    public float attackReach = 2;
    public float attackDelay = 1;
    public float DamageAmount = 10;
    public SphereCollider playerDetector; //Added DW

    private NavMeshAgent agent;
    private float attackCooldown;
    private Health Health; //Added DW
    
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        Health = GetComponent<Health>(); //Added DW

    }

    private void Update()
    {
        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > attackReach)
            {
                agent.isStopped = false;
                agent.destination = target.transform.position;

            }
            else
            {
                agent.isStopped = true;
                Attack();
            }
            
        }


        if (attackCooldown > 0)
            {
                attackCooldown -= Time.deltaTime;
            }

        if ((Health.health) < (Health.maxHealth)) //Added DW
        {
            playerDetector.radius = 30f;
        }
    }



    private void Attack()
    {
        if (attackCooldown <= 0)
        {
            Health targetHealth = target.GetComponent<Health>();
            if (targetHealth != null) 
            {
                targetHealth.Damage(DamageAmount);
            }

            attackCooldown = attackDelay;
        }
    }
}
