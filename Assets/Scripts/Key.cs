using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour, IInteractable
{
    public void Interact(GameObject owner)
    {
        Inventory.Instance.AddKey();
        Destroy(gameObject);
    }
}
