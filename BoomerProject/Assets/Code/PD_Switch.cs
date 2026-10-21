using UnityEngine;

public class PD_Switch : MonoBehaviour
{
    [SerializeField] private GameObject SwitchBase;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchCode Switch = SwitchBase.GetComponent<SwitchCode>();
            if (Switch != null)
            {
                Switch.PlayerClose = true;
            }
        }

    }


    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            SwitchCode Switch = SwitchBase.GetComponent<SwitchCode>();
            if (Switch != null)
            {
                Switch.PlayerClose = false;
            }

        }

    }
}
