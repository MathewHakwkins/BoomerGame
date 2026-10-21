using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class ENRangeBehavior : MonoBehaviour
{
    public GameObject target;
    public float attackReach = 5;
    public float attackDelay = 2;
    public float DamageAmount = 10;
    public SphereCollider playerDetector; //Added DW
    public GameObject BodyModel;
    public Weapon weapon;

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
                agent.transform.rotation = Quaternion.LookRotation(target.transform.position - agent.transform.position);
                                                                        
                                                                                                                                

            }
            else
            {   
                agent.transform.rotation = Quaternion.LookRotation(target.transform.position - agent.transform.position);
                agent.isStopped = true;
                
                RaycastHit hit;

                if ((Physics.Raycast(BodyModel.transform.position, BodyModel.transform.forward, out hit)) && (attackCooldown <= 0))
                {
                    Health targetHealth = hit.transform.GetComponent<Health>();
                    if (targetHealth != null)
                     {
                            Attack();
                         targetHealth.Damage(DamageAmount);
                            attackCooldown = attackDelay;

                     }

            }
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
            
            Weapon Weapon = weapon.GetComponent<Weapon>();
            if (Weapon != null)
            {
                Weapon.Shoot.Play();
            }
            

            
        }
    }
}
