using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

    public GameObject playGameButton;
    public AnimationClip[] movimentCamera;
    public static bool playGame;
    public Ball ball;
    private new GameObject camera;

    public Text messageText;
    public GameObject message;
    public Animator tutorial;

    private new GameObject audio;

    private void Start()
    {

        camera = GameObject.Find("PaiCamera");

        Time.timeScale = 0f;

        if (PlayMenuInicial.activeMenuButton)
        {
            playGameButton.SetActive(true);
        }
    }

    public void playgame()
    {
        playGame = true;
        Time.timeScale = 1f;
    }

    public void ResetSave()
    {
        audio = GameObject.Find("ObjectMusic") as GameObject;
        Time.timeScale = 1f;
        PlayerPrefs.DeleteAll();
        StartCoroutine(ReloadScene());
        audio.GetComponent<AudioSource>().Stop();
    }

    IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("introducao");
    }

    public void Credits()
    {
        camera.GetComponent<CameraPai>().AnimaCamera(movimentCamera[0]);
    }

    public void CreditsExit()
    {
        camera.GetComponent<CameraPai>().AnimaCamera(movimentCamera[1]);
    }

    public void GetSkin(Skins skin)
    {
        if (skin.score <= PlayerPrefs.GetInt("Record"))
        {
            ball.GetComponent<Ball>().SetSprite(skin);
            PlayerPrefs.SetInt("SkinId", skin.skinId);
        }
        else
        {
            messageText.text = skin.message;
            message.SetActive(true);
        }
    }

    public void Skin()
    {
        camera.GetComponent<CameraPai>().AnimaCamera(movimentCamera[2]);
    }

    public void SkinExit()
    {
        camera.GetComponent<CameraPai>().AnimaCamera(movimentCamera[3]);
    }

    public void ExitGame()
    {
        Debug.Log("Saiu");
        Application.Quit();
    }
}
