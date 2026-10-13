using UnityEngine;

public class HealBoxCode : MonoBehaviour
{
    public float Healing = 10;


    public void HealPlayer(Health health)
    {
        health.Heal(Healing);
        Destroy(gameObject);
    }
}
