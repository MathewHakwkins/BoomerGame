using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Camera cam;
    public float damage = 10;
    public float attackDelay = 1;
    private float attackCooldown;

    private void Update()
    {
        if (attackCooldown > 0)
        {
            attackCooldown -= Time.deltaTime;
        }
    }
    public void Fire()
    {

        if (attackCooldown <= 0)
        {

            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
            {
                Health hitHealth = hit.transform.parent.GetComponent<Health>();
                if (hitHealth != null)
                {
                    hitHealth.Damage(damage);
                }

            }
            attackCooldown = attackDelay;
        }
    }
}
