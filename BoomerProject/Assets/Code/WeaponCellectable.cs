using UnityEngine;

public class WeaponCellectable : MonoBehaviour
{
    public Weapon weaponPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WeaponHandler weaponHandler = other.GetComponent<WeaponHandler>();
            if (weaponHandler != null)
            {
                Weapon weapon = GameObject.Instantiate(weaponPrefab);
                weaponHandler.Equip(weapon);
                Destroy(gameObject);
            }

        }
    }
}
