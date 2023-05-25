using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.EventSystems;

public class nomesanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public objekti objectuScripts;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag.Equals(tag))
            {
				vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba = Mathf.Abs(velkObjZRot -  vietasZRot);

                velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;

				vietasIzm = GetComponent<RectTransform>().localScale;

				xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

				if ((rotacijasStarpiba <= 15 || (rotacijasStarpiba >= 345 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.2 && yIzmeruStarp <= 0.2))
				{

					objectuScripts.vaiIstajaVieta = true;

					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;

					switch (eventData.pointerDrag.tag) {
						case "atkritumi":
							objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[1]);
							break;
                        case "medecina":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[2]);
                            break;
                        case "buss":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[3]);
                            break;
                    }
                }
            }
			else
			{
				objectuScripts.vaiIstajaVieta = false;
				objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[0]);
                switch (eventData.pointerDrag.tag)
                {
                    case "atkritumi":
                        objectuScripts.atkritumi.GetComponent<RectTransform>().localPosition = objectuScripts.atkrKoord;
                        break;
                    case "medecina":
                        objectuScripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objectuScripts.atraKord;
                        break;
                    case "buss":
                        objectuScripts.autobuss.GetComponent<RectTransform>().localPosition = objectuScripts.bussKord;
                        break;
                }
            }
        }
    }
}
