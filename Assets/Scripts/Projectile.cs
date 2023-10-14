using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed; // speed of bullet
    [SerializeField] public int damage; 

    // Update is called once per frame
    void Update()
    {
        // moves the bullet fowards depending on speed
        transform.Translate(Vector3.up * speed * Time.deltaTime); 
    }
}
