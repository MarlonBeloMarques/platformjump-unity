using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorPlataforma : Cor {

	// Use this for initialization
	void Start () {

        cor.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f);

    }
	
}
