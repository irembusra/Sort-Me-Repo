using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour, IDropHandler
{

    public GameObject Item

    {
        get
        {
            if (transform.childCount > 0)
            {

                return transform.GetChild(0).gameObject;
            }


            return null;
        }
    }

    public int slotOrder;
    int itemsToShift;

    GameManager GM;

    void Start()
    {
        GM = GameObject.Find("GM").GetComponent<GameManager>();

    }

    void Update()
    {

        //there should be a better way to do this...

        //if (transform.childCount > 0)
        //{
        //    this.GetComponent<GridLayoutGroup>().padding.top = 12;
        //}

        //else

        //    this.GetComponent<GridLayoutGroup>().padding.top = 52;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!Item)
        {
            if (DragHandler.itemBeingDragged.transform.parent.tag == "Slot")
            {
                GM.orderedEvent[DragHandler.itemBeingDragged.transform.parent.GetComponent<SlotScript>().slotOrder] = null;
                DragHandler.itemBeingDragged.transform.SetParent(transform);
                GM.orderedEvent[DragHandler.itemBeingDragged.transform.parent.GetComponent<SlotScript>().slotOrder] = DragHandler.itemBeingDragged;

            }
            else
            {
                DragHandler.itemBeingDragged.transform.SetParent(transform);
                GM.orderedEvent[DragHandler.itemBeingDragged.transform.parent.GetComponent<SlotScript>().slotOrder] = DragHandler.itemBeingDragged;
                GM.Spawn = true;
            }

        }

        else if (DragHandler.itemBeingDragged.transform.parent.tag == "Slot")
        {
            Transform Temp = DragHandler.itemBeingDragged.transform.parent;

            DragHandler.itemBeingDragged.transform.SetParent(transform);
            GM.orderedEvent[DragHandler.itemBeingDragged.transform.parent.GetComponent<SlotScript>().slotOrder] = DragHandler.itemBeingDragged;

            Item.transform.SetParent(Temp);
            GM.orderedEvent[Temp.GetComponent<SlotScript>().slotOrder] = Temp.GetChild(0).gameObject;
        }

        else if (Item)
        {
            itemsToShift = 0;
            for (int i = Item.transform.parent.GetComponent<SlotScript>().slotOrder; i < GM.orderedEvent.Length; i++)
            {
                if (GM.orderedEvent[i] != null)
                {

                    itemsToShift++;
                    continue;
                }
                else
                {
                    //Debug.Log(itemsToShift);
                    //Debug.Log(Item.transform.parent.GetComponent<SlotScript>().slotOrder);
                    break;
                }
            }
            if (itemsToShift == 1 && Item.transform.parent.GetComponent<SlotScript>().slotOrder < 6)
            {
                int moveTo = GM.orderedEvent[Item.transform.parent.GetComponent<SlotScript>().slotOrder].transform.parent.GetSiblingIndex() + 1;
                //Debug.Log(moveTo);
                int movingIndex = Item.transform.parent.GetComponent<SlotScript>().slotOrder;
                GM.orderedEvent[Item.transform.parent.GetComponent<SlotScript>().slotOrder + 1] = GM.orderedEvent[Item.transform.parent.GetComponent<SlotScript>().slotOrder];

                GM.orderedEvent[Item.transform.parent.GetComponent<SlotScript>().slotOrder].transform.SetParent(
                GM.orderedEvent[Item.transform.parent.GetComponent<SlotScript>().slotOrder].transform.parent.parent.GetChild(moveTo));

                GM.orderedEvent[movingIndex] = DragHandler.itemBeingDragged.gameObject;
                GM.orderedEvent[movingIndex].transform.SetParent(GM.orderedEvent[movingIndex + 1].transform.parent.parent.GetChild(moveTo - 1));
                GM.Spawn = true;
            }

        }

    }
}