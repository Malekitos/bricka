using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objekti : MonoBehaviour {

    public Canvas Canvas;


    public GameObject atkritumi;
	public GameObject atraPalidziba;
	public GameObject autobuss;
    public GameObject bmwUniversal;
    public GameObject cements;
    public GameObject e46;
    public GameObject e61;
    public GameObject eskavarots;
    public GameObject policija;
    public GameObject traktors;
    public GameObject traktors5;
    public GameObject ugunsDzesejs;


    [HideInInspector]
	public Vector2 atkrKord;
    [HideInInspector]
    public Vector2 atraKord;
	[HideInInspector]
    public Vector2 bussKord;
    [HideInInspector]
    public Vector2 bmwUniversalKord;
    [HideInInspector]
    public Vector2 cementsKord;
    [HideInInspector]
    public Vector2 e46Kord;
    [HideInInspector]
    public Vector2 e61Kord;
    [HideInInspector]
    public Vector2 eskavarotsKord;
    [HideInInspector]
    public Vector2 policijakord;
    [HideInInspector]
    public Vector2 traktorsKord;
    [HideInInspector]
    public Vector2 traktors5Kord;
    [HideInInspector]
    public Vector2 ugunsDzesejsKord;

    public Canvas canvas;

	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

    // Use this for initialization
    void Start () {
		atkrKord = atkritumi.GetComponent<RectTransform>().localPosition;
        atraKord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKord = autobuss.GetComponent<RectTransform>().localPosition;

        bmwUniversalKord = bmwUniversal.GetComponent<RectTransform>().localPosition;
        cementsKord = cements.GetComponent<RectTransform>().localPosition;
        e46Kord = e46.GetComponent<RectTransform>().localPosition;

        e61Kord = e61.GetComponent<RectTransform>().localPosition;
        eskavarotsKord = eskavarots.GetComponent<RectTransform>().localPosition;
        policijakord = policija.GetComponent<RectTransform>().localPosition;

        traktorsKord = traktors.GetComponent<RectTransform>().localPosition;
        traktors5Kord = traktors5.GetComponent<RectTransform>().localPosition;
        ugunsDzesejsKord = ugunsDzesejs.GetComponent<RectTransform>().localPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
