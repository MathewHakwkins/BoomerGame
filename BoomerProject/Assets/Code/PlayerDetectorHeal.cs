using UnityEngine;

public class PlayerDetectorHeal : MonoBehaviour
{

    [SerializeField] private GameObject HealBox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealBoxCode Healbox = HealBox.GetComponent<HealBoxCode>();
            Health Health = other.GetComponent<Health>();
            if ((Healbox != null) && (Health != null))
            {
                Healbox.HealPlayer(Health);
            }

        }
    }


}
