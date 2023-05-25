using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //uzglabas noradi uz Objekti skriptu
    public objekti objektuSkripts;
    //Uzglabas noradi uz katra objekta CanvaGroup
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTrans;
    public void OnBeginDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        velkObjRectTrans.anchoredPosition = eventData.delta / objektuSkripts.canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;

        if (objektuSkripts.vaiIstajaVieta == false) {
            kanvasGrupa.blocksRaycasts = true;
        }else
        {
            objektuSkripts.pedejaisVilktais = null;
            objektuSkripts.vaiIstajaVieta = false;
        }
    }


    void Start()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTrans = GetComponent<RectTransform>();
    }



}