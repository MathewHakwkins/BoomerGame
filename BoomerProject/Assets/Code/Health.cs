using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth = 100;
    public float health;


    private void Awake()
    {
        health = maxHealth;
    }

    public void Damage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }


    public void Heal(float Healamount)
    {
        if (maxHealth < (health + Healamount))
        {
            Healamount = maxHealth - health;
            health += Healamount;
        }
        else
        {
            health += Healamount;
        }
        Debug.Log(health);
    }
}
