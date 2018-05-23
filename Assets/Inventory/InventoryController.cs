using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {

    public List<ItemBase> inventoryItems;
    public static InventoryController instance;

    // Use this for initialization
    void Start () {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddItemToInventory(ItemBase item)
    {
        inventoryItems.Add(item);
        item.gameObject.SetActive(false);
    }

}
