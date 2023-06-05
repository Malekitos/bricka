using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class objekti : MonoBehaviour {

    public Canvas Canvas;


    public GameObject atkritumi;
	public GameObject atraPalidziba;
	public GameObject autobuss;
    public GameObject bmwUniversal;
    public GameObject cements;
    public GameObject e46;
    public GameObject e61;
    public GameObject eskavators;
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
    public Vector2 eskavatorsKord;
    [HideInInspector]
    public Vector2 policijaKord;
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

    public int PareizuMasinuSkaits; // mainigais kurais skait cik masinas ir pareizi novietotas
    public Sprite[] atteluMasivs; // viena spraita bus tris atteli, 1,2,3 zvaigznes
    public GameObject zvaigznes; // sprite ar zvaigznem
    public GameObject panel; // panel uz kuras paradas rezultats
    public GameObject pogaReset; // poga reset
    public GameObject taimer;
    public int zvaigznesSkaits = 1; // cik zvaigznes vajadzes attelot

    public float mil;
    public int sec;
    public int min;
    public int h;
    public Text text;

    private void FixedUpdate() {


        if (PareizuMasinuSkaits<12) {
            mil += 0.02f;
        }
        
        if (mil >= 1)
        {
            sec++;
            mil = 0;
        }
        if (sec >= 60)
        {
            min++;
            sec = 0;
      
        }

        if (min >= 60)
        {
            h++;
            min = 0;
        }
        text.text = $"{h}: {min} : {sec}";

        switch (min) {
            case 0:zvaigznesSkaits = 2;break;
            case 1: zvaigznesSkaits = 1; break;
            case 2: zvaigznesSkaits = 0; break;
        }
        if (h > 0) {
            zvaigznesSkaits = 0;
        }
    }

    // Use this for initialization
    void Start () {

      

		atkrKord = atkritumi.GetComponent<RectTransform>().localPosition;
        atraKord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKord = autobuss.GetComponent<RectTransform>().localPosition;

        bmwUniversalKord = bmwUniversal.GetComponent<RectTransform>().localPosition;
        cementsKord = cements.GetComponent<RectTransform>().localPosition;
        e46Kord = e46.GetComponent<RectTransform>().localPosition;

        e61Kord = e61.GetComponent<RectTransform>().localPosition;
        eskavatorsKord = eskavators.GetComponent<RectTransform>().localPosition;
        policijaKord = policija.GetComponent<RectTransform>().localPosition;

        traktorsKord = traktors.GetComponent<RectTransform>().localPosition;
        traktors5Kord = traktors5.GetComponent<RectTransform>().localPosition;
        ugunsDzesejsKord = ugunsDzesejs.GetComponent<RectTransform>().localPosition;

        zvaigznes.SetActive(false);
        pogaReset.SetActive(false);
        panel.SetActive(false);
        taimer.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

   

    public void rezultats() {
        if (PareizuMasinuSkaits >= 12)
        { // ja visas 12 masinas pareizi novietotas, tad paradam laiku, zvaigznes, pogu RESET un panel(skaistumam)
            zvaigznes.SetActive(true); // paradas rezultati
            pogaReset.SetActive(true);
            panel.SetActive(true);
            taimer.SetActive(true);

           
            switch (zvaigznesSkaits)
            {
                case 0:
                    zvaigznes.GetComponent<Image>().sprite = atteluMasivs[0]; break;

                case 1:
                    zvaigznes.GetComponent<Image>().sprite = atteluMasivs[1]; break;

                case 2:
                    zvaigznes.GetComponent<Image>().sprite = atteluMasivs[2]; break;

            }
            

        }
    }

    public void pogaResetDarbiba() {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    


}
