using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorText : Cor {

	// Use this for initialization
	void Start () {

        cor.GetComponent<Text>().color = Random.ColorHSV(0f, 1f);

    }
	
}
