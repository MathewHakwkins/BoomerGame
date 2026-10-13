using UnityEngine;

public class AmmoBox : MonoBehaviour
{

    public float AmmoAmount = 5;

    public void ReloadAmmo(Weapon Weapon)
    {
        Weapon.Ammo += AmmoAmount;
        Debug.Log(Weapon.Ammo);
        Destroy(gameObject);
    }
}
