using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    public Sloting2 komponen;
    public Sloting1 komponens;
    public GameObject feed_benar, feed_salah;
    // public Helath KomponenHealth;
    // public Poin KomponenPoin;
    public int id;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item Dropped");
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragAndDrop>().id == id)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
                if(komponen != null){
                    Poingame();
                }
                if(komponens != null){
                    Poingame2();
                    Debug.Log("Jalan");
                }
                
            }
            else
            {
                Debug.Log("Salah");
                eventData.pointerDrag.GetComponent<DragAndDrop>().resetposisi();
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
                // Health();
            }
        }
      
    }

    void Poingame(){
        komponen.Skor++;
    }
    void Poingame2(){
        komponens.Skor++;
    }
}
