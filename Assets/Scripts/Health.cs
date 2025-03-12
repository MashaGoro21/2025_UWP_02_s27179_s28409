using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth = 100f;
    public float currentHealth;
    
    public delegate void HealthChanged(float current, float max);
    public event HealthChanged OnHealthChanged;

    private void Awake()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        if (currentHealth == 0)
        {
            currentHealth = maxHealth;
        }
        
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }
    
    public void AddHealth(float amount)
    {
        if( amount < 0 ) return;
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }
    
    public void RemoveHealth(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        
        OnHealthChanged?.Invoke(currentHealth, maxHealth);

        if (currentHealth <= 0f)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
