using UnityEngine;

public class DoorCode : MonoBehaviour
{
    public Animator Animation;
    public bool PlayerClose = false;





    public void OpenDoor()
    {
        if (PlayerClose)
        {
            Animation.SetBool("IsOpen", true);
        }
    }



}
