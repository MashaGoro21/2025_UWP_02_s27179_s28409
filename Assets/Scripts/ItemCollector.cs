using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ItemCollector : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        IInteractable interactable = collision.gameObject.GetComponent<IInteractable>();
        interactable?.Interact(gameObject);
    }

}
