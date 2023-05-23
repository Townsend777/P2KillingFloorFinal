using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 2;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

   void TakeDamage(int amount)
    {
        currentHealth += amount;  

        if(currentHealth <= 0)
        {
            // we're dead 
            // Play Death animation 
            // Show GameOver screen
        }
    }
}
