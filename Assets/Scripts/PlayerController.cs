using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed; // for the speed of the character
    [SerializeField] private Transform weapon; // transform so that the weapon aims with the cursor
    private float offset; // to readjust/realign weapon with mouse

    // Start is called before the first frame update
    void Start()
    {
        offset = 90; // realigning by 90 degrees
    }

    // Update is called once per frame
    void Update()
    {
        // PLAYER MOVEMENT with wasd
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        // moves player, normalized to fix speed when moving diagonally
        // Time.deltaTime to make movement framerate dependent
        transform.position += playerInput.normalized * speed * Time.deltaTime;

        // WEAPON ROTATION with mouse
        // returns space between the weapon and mouse cursor 
        // screentoworldpoint is to convert mouseposition units from pixels to coordinates
        Vector3 displacement = weapon.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // get angle and convert it from radians to degrees
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        // finally do the rotation + offset since center was point at mouse before
        weapon.rotation = Quaternion.Euler(0, 0, angle + offset);
    }
}
