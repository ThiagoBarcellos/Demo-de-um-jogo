using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotBehaviour: MonoBehaviour
{

    public ItemBase currentItem;
    public Image iconItemSlot;
    public GameObject amountIndicator;
    public Text amountText;
    

    // Use this for initialization
    void Start()
    {
        SetupSlot();
        
    }

    public void SetupSlot()
    {
        if (currentItem != null)
        {
            SetActiveSlot(true);
            iconItemSlot.sprite = currentItem.icon;

            if (currentItem.isStackLabel)
            {
                amountText.text = currentItem.getAmout().ToString();
            }
            else
            {
                amountIndicator.SetActive(false);
            }
        }
        else
        {
            SetActiveSlot(false);
        }
    }

    
    public void SetActiveSlot(bool isActive = true)
    {
        amountIndicator.SetActive(isActive);
        iconItemSlot.gameObject.SetActive(isActive);
    }
   
}
