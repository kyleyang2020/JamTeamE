using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed; // for the speed of the character
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        // PLAYER MOVEMENT with wasd
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        if(playerInput.sqrMagnitude > 0)
        {
            animator.Play("playerWalk");
        }
        else
        {
            animator.Play("playerStand");
        }
        // moves player, normalized to fix speed when moving diagonally
        // Time.deltaTime to make movement framerate dependent
        transform.position += playerInput.normalized * speed * Time.deltaTime;
    }
}
