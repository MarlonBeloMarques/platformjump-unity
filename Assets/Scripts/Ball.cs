using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    private new GameObject camera;
    public ControleG controleG;
    private Rigidbody2D rig;
    public SpriteRenderer sprite;
    public float forcaP;
    private float horizont;
    public float veloc;
    private float moviment;
    public static int pontuacao;
    public Text pontuacaoText;

    private float currentime;
    public float limiteContagem;
    public GameObject gameOver;
    public GameObject pontuacaoObject;
    public GameObject startPauseUi;

    public Skins skinBall;

    public Skins[] skinList;

	// Use this for initialization
	void Start () {

        SetSprite(PlayerPrefs.GetInt("SkinId"));

        camera = GameObject.Find("Main Camera");
        rig = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        pontuacao = 0;
        camera.GetComponent<Camera>().limiteLevel = 10;
	}
	
	// Update is called once per frame
	void Update () {

        sprite.sprite = skinBall.skinSprite;
      
        currentime += Time.deltaTime;

        if (currentime >= limiteContagem)
        {
            currentime = 0;
            pontuacao += 1;
            if(pontuacao >= camera.GetComponent<Camera>().limiteLevel)
            {
                camera.GetComponent<Camera>().contLogicVeloc += 0.2f; // velocidade da camera // OK   
                controleG.GetComponent<ControleG>().contSetVeloc += 0.2f; // velocidade spawn  // OK

                camera.GetComponent<Camera>().limiteLevel += 10;
            }
        }

        pontuacaoText.text = pontuacao.ToString();

        moviment = Input.acceleration.x;

        rig.velocity = new Vector3(veloc * moviment, rig.velocity.y);

        if(transform.position.y <= -5.85f)
        {
            Destroy(gameObject);
            gameOver.SetActive(true);
            Point();
            Time.timeScale = 0f;
        }
	}

    public void Jump()
    {
        rig.AddForce(new Vector2(0, forcaP));
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ColisorPared"))
        {
            Destroy(gameObject);
            gameOver.SetActive(true);
            Point();
            Time.timeScale = 0f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bonus"))
        {
            Destroy(collision.gameObject);
            camera.GetComponent<Camera>().SetVelocidade(0.2f);
        }
    }

    private void Point()
    {
        PlayerPrefs.SetInt("Score", pontuacao);
        if (pontuacao >= PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", pontuacao);
        }
        pontuacaoObject.SetActive(false);
        startPauseUi.SetActive(false);
    }

    public void SetSprite(Skins skin)
    {
        skinBall = skin;
    }

    public void SetSprite(int skinId)
    {
        if(skinId == 1)
        {
            skinBall = skinList[0];
        }
        if(skinId == 2)
        {
            skinBall = skinList[1];
        }
        if(skinId == 3)
        {
            skinBall = skinList[2];
        }
        if(skinId == 4)
        {
            skinBall = skinList[3];
        }
        if(skinId == 5)
        {
            skinBall = skinList[4];
        }

        skinBall.skinId = skinId;
        sprite.sprite = skinBall.skinSprite;
    }

}
