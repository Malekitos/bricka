using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class objektuParvietosana : MonoBehaviour {
	public objekti objektuSkripts;

	
	// Update is called once per frame
	void Update () {
		if(objektuSkripts.pedejaisVilktais != null)
		{
			if(Input.GetKey(KeyCode.Z))
			{
				objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0,0, Time.deltaTime * 15f);
			}
            if (Input.GetKey(KeyCode.X))
            {
                objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 15f);
            }
        }
	}
}
