using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {
    private RectTransform rectTransform;

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("ONPOINTER DOWN");
    }

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");
    }
    public void OnDrag(PointerEventData eventData) {
        rectTransform.anchoredPosition += eventData.delta;
    }

}
