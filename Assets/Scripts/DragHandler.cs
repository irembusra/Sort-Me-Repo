using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

   
    
    
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
      //  Debug.Log("bir");


    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        //  GameManager.instance.b_isplaced = true;
        //Debug.Log(itemBeingDragged.transform.parent.tag);
        //Debug.Log("iki");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
      
        }
       // Debug.Log("üç");
     //   GameManager.instance.b_isplaced = false;
    }
}
