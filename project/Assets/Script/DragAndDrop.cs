using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTras;
    public Canvas myCanvas;
    private CanvasGroup canvasGroup;
    private Vector2 inipost;
    private Vector3 scale_awal;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        rectTras = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        inipost = transform.position;
        scale_awal = transform.localScale;
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
        canvasGroup.blocksRaycasts = false;
        transform.localScale = new Vector2(1f, 1f);
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Debug.Log("OnDrag");
        rectTras.anchoredPosition += eventData.delta / myCanvas.scaleFactor;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        canvasGroup.blocksRaycasts = true;
        transform.localScale = new Vector2(1f, 1f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("CLICK");
    }

    public void resetposisi()
    {
        transform.position = inipost;
        transform.localScale = scale_awal;
    }


}
