using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed; // for the speed of the character

    // Update is called once per frame
    void Update()
    {
        // PLAYER MOVEMENT with wasd
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        // moves player, normalized to fix speed when moving diagonally
        // Time.deltaTime to make movement framerate dependent
        transform.position += playerInput.normalized * speed * Time.deltaTime;
    }
}
