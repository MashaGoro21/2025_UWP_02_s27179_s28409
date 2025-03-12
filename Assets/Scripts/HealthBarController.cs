using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarController : MonoBehaviour
{

    public Health health;
    
    public Image HealthBarFill;

    // Start is called before the first frame update
    void Start()
    {
        health.OnHealthChanged += UpdateHealthBar;
        
        UpdateHealthBar(health.currentHealth, health.maxHealth); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void UpdateHealthBar(float current, float max)
    {
        float fillAmount = current / max;
        if (HealthBarFill != null)
        {
            HealthBarFill.fillAmount = fillAmount;
        }
    }

}
