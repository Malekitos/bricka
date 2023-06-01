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
				objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0,0, Time.deltaTime * 20f);
			}
            if (Input.GetKey(KeyCode.X))
            {
                objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 20f);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
				if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y <= 1.50f) {
					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale =
						new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y + 0.005f);
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y >= 0.45f)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y - 0.005f);
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x <= 1.50f)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x + 0.005f, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y );
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x >= 0.45f)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x- 0.005f, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y) ;
                }
            }

        }
	}
}
