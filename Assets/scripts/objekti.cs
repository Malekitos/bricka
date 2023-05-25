using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objekti : MonoBehaviour {

    public Canvas Canvas;


    public GameObject atkritumi;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	[HideInInspector]
	public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atraKord;
	[HideInInspector]
    public Vector2 bussKord;

	public Canvas canvas;

	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

    // Use this for initialization
    void Start () {
		atkrKoord = atkritumi.GetComponent<RectTransform>().localPosition;
        atraKord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKord = autobuss.GetComponent<RectTransform>().localPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
