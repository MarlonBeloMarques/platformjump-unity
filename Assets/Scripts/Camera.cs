using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public float velocAtual;
    private float currenTime;
    public ControleG controleG;
    public float contLogicVeloc;
    public int limiteLevel;
    

    private void Start()
    {
        velocAtual = 1f;
    }

    void Update () {

        if (PlayGame.playGame)
        {
            Controle_Veloc();
        }
	}

    private void Controle_Veloc()
    {
        if (Ball.pontuacao >= 10 && Ball.pontuacao <= limiteLevel)
        {
            LogicaVelocidade(1f + contLogicVeloc);
            controleG.GetComponent<ControleG>().SetVelocidade(controleG.GetComponent<ControleG>().velocAux + controleG.GetComponent<ControleG>().contSetVeloc);
            controleG.GetComponent<ControleG>().LimiteTime(controleG.GetComponent<ControleG>().ContLimiteTime(controleG.GetComponent<ControleG>().veloc, 14.4f)); // inicia em 9
        }
        if (Ball.pontuacao >=2 && Ball.pontuacao <3) // era 10
        {
            controleG.GetComponent<ControleG>().currenTime = 0f;
            controleG.GetComponent<ControleG>().LimiteTime(11f);
        }

        transform.Translate(Vector2.right * velocAtual * Time.deltaTime);

    }

    public void SetVelocidade(float veloc)
    {
        velocAtual -= veloc;
    }

    public void LogicaVelocidade(float veloc)
    {
        int cont = 0;

        if (cont < 1)
        {
            currenTime += Time.deltaTime;
        }
 
        float limiTime = 1f;

        if(currenTime >= limiTime)
        {
            currenTime = 0;
            cont++;
            velocAtual = veloc;
        }
    }
}
