using UnityEngine;

public class PlayerDetectAmmo : MonoBehaviour
{
    [SerializeField] private GameObject AmmoBox;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AmmoBox Ammobox = AmmoBox.GetComponent<AmmoBox>();
            WeaponHandler weaponcheck = other.GetComponent<WeaponHandler>();
            if ((weaponcheck.equippedWeapon != null) && (AmmoBox != null))
            {

                Ammobox.ReloadAmmo(weaponcheck.equippedWeapon);
            }


        }
    }
}
