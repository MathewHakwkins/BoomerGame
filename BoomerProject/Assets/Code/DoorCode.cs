using UnityEngine;

public class DoorCode : MonoBehaviour
{
    public Animator Animation;
    



    private void Update()
    {
        
    }

    public void OpenDoor()
    {
        
        
            Animation.SetBool("IsOpen", true);
        
    }



}
