using UnityEngine;

public class PD_Exit : MonoBehaviour
{
    [SerializeField] private GameObject ExitBase;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ExitCode Exit = ExitBase.GetComponent<ExitCode>();
            if (Exit != null)
            {
                Exit.PlayerClose = true;

                
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ExitCode Exit = ExitBase.GetComponent<ExitCode>();
            if (Exit != null)
            {
                Exit.PlayerClose = false;

            }


        }
    }

}
