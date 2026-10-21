using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public Transform weaponAnchor;
    public Camera mainCam;

    public GameObject UI;
    private UICode AmmoUI;
    private float CurrentAmmo = 10;

    public Weapon equippedWeapon;

    private void Awake()
    {
        if ((UI.GetComponent<UICode>()) != null)
        {
            AmmoUI = UI.GetComponent<UICode>();
        }
    }

  
    private void OnAttack()
    {
        if (equippedWeapon != null)
        {
            equippedWeapon.Fire();
            AmmoUI.UpdateAmmo(equippedWeapon.Ammo);
            
            
        }

    }


    public void Equip(Weapon weapon)
    {
        equippedWeapon = weapon;
        weapon.transform.parent = weaponAnchor;
        weapon.transform.position = weaponAnchor.position;
        weapon.transform.rotation = weaponAnchor.rotation;
        weapon.cam = mainCam;
        

    }
}
