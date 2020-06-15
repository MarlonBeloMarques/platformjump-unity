using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPai : MonoBehaviour {

    private Animator anima;

	// Use this for initialization
	void Start () {
        anima = GetComponent<Animator>();
	}

    public void AnimaCamera(AnimationClip animaReceb)
    {
        anima.Play(animaReceb.name);
    }
}
