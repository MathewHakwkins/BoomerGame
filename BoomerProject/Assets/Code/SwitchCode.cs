using UnityEngine;

public class SwitchCode : MonoBehaviour
{
    public bool PlayerClose = false;

    [SerializeField] private GameObject Door;


    public void SwitchFlip()
    {
        DoorCode LockedDoor = Door.GetComponent<DoorCode>();
        if ((LockedDoor != null) && (PlayerClose))
        {
            
            LockedDoor.OpenDoor();
        }
    }
}
