using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 4;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;


        if (currentHealth <= 0)
        {
            Debug.Log("Is dead");
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
