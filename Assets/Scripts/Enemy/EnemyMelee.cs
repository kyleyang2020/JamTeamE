using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMelee : MonoBehaviour
{
    [SerializeField] private float speed; // speed of the enemy
    [SerializeField] private float damage; // damage of the enemy
    Transform player; // reference of player for the enemy to move towards player

    // Start is called before the first frame update
    void Start()
    {
        // actually finds transform component of the player so move towards their location
        player = FindObjectOfType<PlayerMovement>().transform; 
    }

    // Update is called once per frame
    void Update()
    {
        // move towards player position, at certain speed
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the enemy touches a player, player take damage
        if (collision.tag == "Player")
            collision.GetComponent<Health>().TakeDamage(damage);
    }
}
