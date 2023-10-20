using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmDamage : MonoBehaviour
{

    [SerializeField] Sprite[] damageSprites;
    Health health;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = damageSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(health.currentHealth <= 4)
        {
            sprite.sprite = damageSprites[1];
        }

        if(health.currentHealth <= 2)
        {
            sprite.sprite = damageSprites[2];
        }
    }
}
