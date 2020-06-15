using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleG : MonoBehaviour {

    public float currenTime;
    public float limiTime;

    public List<GameObject> plataforms;
    private GameObject platAux;
    public Transform positionInstantiate;
    public float contSetVeloc;
    public float veloc;
    public float velocAux = 1.4f;

    void Update () {

        transform.Translate(Vector2.right * veloc * Time.deltaTime);

        Instanciar_Plat();
     	
	}

    private void SorteioPlat()
    {
        int aux = Random.Range(0, 120);

        if (aux > 100)
        {
            platAux = plataforms[5];
        }
        else if (aux > 80)
        {
            platAux = plataforms[0];
        }
        else if (aux > 60)
        {
            platAux = plataforms[4];
        }
        else if (aux > 40)
        {
            platAux = plataforms[1];
        }
        else if (aux > 20)
        {
            platAux = plataforms[2];
        }
        else
        {
            platAux = plataforms[3];
        }

    }

    private void Instanciar_Plat()
    {
        currenTime += Time.deltaTime;

        if (currenTime >= limiTime)
        {
            currenTime = 0;

            SorteioPlat();
            InstanciarObject();
            LimiteTime();
        }
    }

    private void InstanciarObject()
    {
        GameObject prefab = Instantiate(platAux) as GameObject;
        prefab.transform.position = new Vector3(positionInstantiate.position.x, positionInstantiate.position.y);
    }

    public void SetVelocidade(float veloc)
    {
        this.veloc = veloc;
    }

    public float LimiteTime()
    {
        return limiTime;
    }

    public void LimiteTime(float limiTime)
    {
        this.limiTime = limiTime;
    }

    public float ContLimiteTime(float contSetVeloc, float distancia)
    {
        return distancia / contSetVeloc;
    }

}
