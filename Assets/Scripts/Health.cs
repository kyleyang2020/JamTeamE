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

    // assigning variables, setting current health
    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        // remove health equal to damage
        currentHealth -= _damage;

        // is player is hurt
        if (currentHealth > 0)
        {
            // singleton baby
            //SoundManager.instance.PlaySound(hurtSound);
        }
        // if player is dead
        else
        {
            //SoundManager.instance.PlaySound(deathSound);
            //SceneManager.LoadScene("End");
            Destroy(gameObject);
        }
    }
}