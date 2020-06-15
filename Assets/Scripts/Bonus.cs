using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x <= GameObject.Find("Main Camera/PontoDetect").transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
