using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColisor : MonoBehaviour {

    public Ball ball;

    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject othercolor = other.gameObject;
        ball.GetComponent<Ball>().Jump();
        ball.GetComponent<SpriteRenderer>().color = othercolor.GetComponent<SpriteRenderer>().color;
    }
}
