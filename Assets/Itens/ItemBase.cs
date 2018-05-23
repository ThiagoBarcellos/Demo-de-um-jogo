using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ItemBase : MonoBehaviour
{

    public Sprite icon;
    protected int amount;
    public bool isStackLabel;
    private bool canTakeItem;
    

    public void addItem(int amountToAdd = 1)
    {
        amount += amountToAdd;
    }

    public int getAmout()
    {
        return amount;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canTakeItem)
        {
            InventoryController.instance.AddItemToInventory(this);
        }

    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            canTakeItem = true;
            FirstPersonController.instance.ShowMessageToTake();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canTakeItem = false;
            
        }
    }

    
}
