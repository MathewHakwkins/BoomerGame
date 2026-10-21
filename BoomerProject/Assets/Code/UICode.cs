using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UICode : MonoBehaviour
{
    public TextMeshProUGUI HealthUIText;
    public TextMeshProUGUI AmmoUIText;

    public float health = 100;
    public float Ammo = 10;

    private void Awake()
    {
        HealthUIText.text = health.ToString();
        AmmoUIText.text = Ammo.ToString();
    }
    public void UpdateHealth(float NewHealth)
    {
        health = NewHealth;
        HealthUIText.text = health.ToString();
    }

    public void UpdateAmmo(float NewAmmo)
    {
        Ammo = NewAmmo;
        AmmoUIText.text = Ammo.ToString();
    }

   
}
