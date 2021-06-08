using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject pickupEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            PickUp(other);
        }
    }

    private void PickUp(Collider2D other) {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
