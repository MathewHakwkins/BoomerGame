using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UICode : MonoBehaviour
{
    public TextMeshProUGUI HealthUIText;
    public TextMeshProUGUI AmmoUIText;

    private float health = 100;
    private float Ammo = 10;

    private void Awake()
    {
        HealthUIText.text = health.ToString();
        
    }
    public void UpdateHealth()
    {
        HealthUIText.text = health.ToString();
    }


   
}
