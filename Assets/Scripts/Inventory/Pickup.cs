using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 


namespace UniRPG.Inventories {
    public class Pickup:MonoBehaviour {
        // STATE
        InventoryItem item; 
        int number;

        // CACHED REFERENCE
        Inventory inventory; 

        // LIFECYCLE METHODS

        private void Awake() {
            var player = GameObject.FindGameObjectWithTag("Player"); 
            inventory = player.GetComponent < Inventory > (); 
        }

        // PUBLIC

        /// <summary>
        /// Set the vital data after creating the prefab.
        /// </summary>
        /// <param name="item">The type of item this prefab represents.</param>
        /// <param name="number">The number of items represented.</param>
        public void Setup(InventoryItem item, int number)
        {
            this.item = item;
            this.number = number;
            /*if (!item.IsStackable())
            {
                number = 1;
            }*/
        }

        public int GetNumber()
        {
            return number;
        }

        public InventoryItem GetItem() {
            return item; 
        }

        public void PickupItem() {
            bool foundSlot = inventory.AddToFirstEmptySlot(item, number); 
            if (foundSlot) {
                Destroy(gameObject); 
            }
        }

        public bool CanBePickedUp() {
            return inventory.HasSpaceFor(item); 
        }
    }
}
