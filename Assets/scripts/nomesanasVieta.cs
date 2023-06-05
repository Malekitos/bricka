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

                    objectuScripts.PareizuMasinuSkaits++; // pieskajtam , mainigajam vienu vienibu pec pareizas novilktas masinas
                    objectuScripts.rezultats(); // izsaukam metodi, kura parbaud vai ir 12 masinas noliktas pareizi



                    switch (eventData.pointerDrag.tag) {
						case "atkritumi":
							objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[1]);
                            break;
                        case "medecina":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[2]);
                            break;
                        case "buss":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[11]);
                            break;
                        case "bmwUniversal":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[4]);
                            break;
                        case "cements":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[10]);
                            break;
                        case "e46":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[6]);
                            break;
                        case "e61":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[5]);
                            break;
                        case "eskavators":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[3]);
                            break;
                        case "policija":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[7]);
                            break;
                        case "traktors":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[8]);
                            break;
                        case "traktors5":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[9]);
                            break;
                        case "ugunsdzesejs":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[12]);
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
                        objectuScripts.atkritumi.GetComponent<RectTransform>().localPosition = objectuScripts.atkrKord;
                        break;
                    case "medecina":
                        objectuScripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objectuScripts.atraKord;
                        break;
                    case "buss":
                        objectuScripts.autobuss.GetComponent<RectTransform>().localPosition = objectuScripts.bussKord;
                        break;
                    case "bmwUniversal":
                        objectuScripts.bmwUniversal.GetComponent<RectTransform>().localPosition = objectuScripts.bmwUniversalKord;
                        break;
                    case "cements":
                        objectuScripts.cements.GetComponent<RectTransform>().localPosition = objectuScripts.cementsKord;
                        break;
                    case "e46":
                        objectuScripts.e46.GetComponent<RectTransform>().localPosition = objectuScripts.e46Kord;
                        break;
                    case "e61":
                        objectuScripts.e61.GetComponent<RectTransform>().localPosition = objectuScripts.e61Kord;
                        break;
                    case "eskavators":
                        objectuScripts.eskavators.GetComponent<RectTransform>().localPosition = objectuScripts.eskavatorsKord;
                        break;
                    case "policija":
                        objectuScripts.policija.GetComponent<RectTransform>().localPosition = objectuScripts.policijaKord;
                        break;
                    case "traktors":
                        objectuScripts.traktors.GetComponent<RectTransform>().localPosition = objectuScripts.traktorsKord;
                        break;
                    case "traktors5":
                        objectuScripts.traktors5.GetComponent<RectTransform>().localPosition = objectuScripts.traktors5Kord;
                        break;
                    case "ugunsdzesejs":
                        objectuScripts.ugunsDzesejs.GetComponent<RectTransform>().localPosition = objectuScripts.ugunsDzesejsKord;
                        break;
                }
            }
            
        }
    }
}
