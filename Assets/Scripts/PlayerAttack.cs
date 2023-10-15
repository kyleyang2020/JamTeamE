using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform weapon; // transform so that the weapon aims with the cursor
    private float offset; // to readjust/realign weapon with mouse

    [SerializeField] private Transform firePoint; // where the projectile would spawn
    [SerializeField] private GameObject bullet; // actual bullet to spawn/shoot

    [SerializeField] private float atkCD; // cd for player bullets
    float atkCDTimer; // to count the time that has passed

    // Start is called before the first frame update
    void Start()
    {
        offset = 90; // realigning by 90 degrees
    }

    // Update is called once per frame
    void Update()
    {
        // WEAPON ROTATION with mouse
        // returns space between the weapon and mouse cursor 
        // screentoworldpoint is to convert mouseposition units from pixels to coordinates
        Vector3 displacement = weapon.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // get angle and convert it from radians to degrees
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        // finally do the rotation + offset since center was point at mouse before
        weapon.rotation = Quaternion.Euler(0, 0, angle + offset);

        // SHOOTING
        if (Input.GetMouseButtonDown(0)) // left click
        {
            if (Time.time > atkCDTimer) // if enough time has passed for cd to be up
            {
                atkCDTimer = Time.time + atkCD; // increment the time up by the CD to be check with in-game time later
                Instantiate(bullet, firePoint.position, firePoint.rotation);
                // spawns the bullet , at the firepoint position and at that rotation
                // following the parameters of the instantiate function
            }
        }

        // MELEE
        if (Input.GetMouseButtonDown(1)) // right click
        {
            
        }
    }
}
