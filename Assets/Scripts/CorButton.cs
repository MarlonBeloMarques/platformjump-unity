using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorButton : Cor {

	// Use this for initialization
	void Start () {

        cor.GetComponent<Image>().color = Random.ColorHSV(0f, 1f);
		
	}
}
