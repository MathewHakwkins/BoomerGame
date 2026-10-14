using UnityEngine;

public class DoorCode : MonoBehaviour
{
    public Animator Animation;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OpenDoor();
        }
    }



    public void OpenDoor()
    {
        Animation.SetBool("IsOpen", true);
    }



}
