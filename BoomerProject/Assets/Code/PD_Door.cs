using UnityEngine;

public class PD_Door : MonoBehaviour
{
    [SerializeField] private GameObject DoorBase;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DoorCode Door = DoorBase.GetComponent<DoorCode>();
            if (Door != null)
            {
                
                
                
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DoorCode Door = DoorBase.GetComponent<DoorCode>();
            if (Door != null)
            {
               
                
            }


        }
    }
}
