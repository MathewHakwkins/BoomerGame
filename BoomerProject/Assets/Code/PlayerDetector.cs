using UnityEngine;

public class PlayerDetector : MonoBehaviour
{

    [SerializeField] private GameObject EnemyAI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           ENMeleeBehavior enemyMelee = EnemyAI.GetComponent<ENMeleeBehavior>();
            if (enemyMelee != null)
            {
                enemyMelee.target = other.gameObject;
            }

        }
    }


}
