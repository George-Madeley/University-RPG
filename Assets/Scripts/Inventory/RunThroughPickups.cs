using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniRPG.Inventories
{
    [RequireComponent(typeof(Pickup))]
    public class RunThroughPickups : MonoBehaviour
    {
        Pickup pickup;

        private void Awake()
        {
            pickup = GetComponent<Pickup>();
        }

        private void OnTriggerEnter2D(Collider2D other) {
            pickup.PickupItem();
        }
    }
}
