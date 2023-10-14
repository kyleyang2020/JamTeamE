using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMelee : MonoBehaviour
{
    [SerializeField] private float speed; // speed of the enemy
    Transform player; // reference of player for the enemy to move towards player

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        // actually finds transform component
        player = FindObjectOfType<PlayerController>().transform; 
    }

    // Update is called once per frame
    void Update()
    {
        // move towards player position, at certain speed
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Projectile")
        {
            TakeDamage(collision.GetComponent<Projectile>().damage);
        }
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("TestScene");
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
