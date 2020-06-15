using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {

    public GameObject bonus;
    public Transform postionBonus;
    public float currenTime=0;
    public float limit;
    private float limiTime=0.5f;

	// Update is called once per frame
	void Update () {

        if (transform.position.x <= GameObject.Find("Main Camera/PontoDetect").transform.position.x)
        {
            Destroy(gameObject);
        }

        if (Ball.pontuacao >= 50)
        {
            if (bonus != null && postionBonus != null)
            {
                Bonus();
            }
        }
	}

    private void Bonus()
    {
        currenTime += Time.deltaTime;

        if (currenTime >= limiTime)
        {
            currenTime = 0;
            float aux = Random.Range(0, 100);

            if (aux > limit)
            {
                InstanciarBonus();
            }

            limiTime = 100f;
        }
    }

    private void InstanciarBonus()
    {
        GameObject prefab = Instantiate(bonus, postionBonus.position, Quaternion.identity);
    }
}
