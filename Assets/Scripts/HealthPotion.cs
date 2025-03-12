using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour, IInteractable
{

    public int healAmount = 10;
    
    public void Interact(GameObject owner)
    {
        Health healthComponent = owner.GetComponent<Health>();
        
        if(healthComponent == null) return;
        
        healthComponent.AddHealth(healAmount);
        Destroy(gameObject);
    }
}
