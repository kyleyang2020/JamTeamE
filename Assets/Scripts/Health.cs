using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    // variables for starting and current health
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    [SerializeField] private bool isPlayer;

    // assigning variables, setting current health
    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        // remove health equal to damage
        currentHealth -= _damage;

        // if player is hurt
        if (isPlayer & currentHealth > 0)
        {

        }
        // if player is dead
        else if(isPlayer & currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        // if enemy is hurt
        else if(currentHealth > 0)
        {

        }
        // if enemy is dead
        else if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}