using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth = 100;
    public float health;
    public GameObject UI;
    private UICode HealthUI;
    private void Awake()
    {
        health = maxHealth;
        if ((UI.GetComponent<UICode>()) != null)
        {
            HealthUI = UI.GetComponent<UICode>();
        }

    }

    public void Damage(float damage)
    {
        health -= damage;
        if (HealthUI != null)
        {
            HealthUI.UpdateHealth(health);
        }


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
        if (HealthUI != null)
        {
            HealthUI.UpdateHealth(health);
        }
    }
}
