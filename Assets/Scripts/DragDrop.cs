using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler 
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begindrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Ondrag");
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("enddrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("DOWWWn");
    }

}