using UnityEngine;

public class ExitCode : MonoBehaviour
{
    public bool PlayerClose = false;






    public void EndCode()
    {
        if (PlayerClose) 
        { 
            Application.Quit();
        }
        
    }
}
