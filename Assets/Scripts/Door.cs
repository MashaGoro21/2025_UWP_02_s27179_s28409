using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    bool isOpen;

    private void Awake()
    {
        isOpen = false;
    }

    public void Interact(GameObject owner)
    {
        int keys = Inventory.Instance.GetKeys();
        if(keys > 0 && !isOpen)
        {
            isOpen = true;
            Inventory.Instance.UseKey();
        }
    }
}
