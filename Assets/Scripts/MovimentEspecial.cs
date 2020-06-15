using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentEspecial : MonoBehaviour {

    public bool Cima=false;
    public float veloc;

    // Update is called once per frame
    private void Update()
    {
        Moviment();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Limite") || collision.gameObject.CompareTag("Ground"))
        {
            Cima = !Cima;
        }
    } 

    private void Moviment()
    {
        transform.Translate(PegarDirecao() * veloc * Time.deltaTime);
    }

    private Vector2 PegarDirecao()
    {
        return Cima ? Vector2.down : Vector2.up;
    }
}
