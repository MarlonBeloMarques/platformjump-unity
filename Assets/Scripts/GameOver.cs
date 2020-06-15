using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text scoreText;
    public Text recordext;

    public PlayGame playGame;

    public void Update()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        recordext.text = PlayerPrefs.GetInt("Record").ToString();
    }

    public void ReturnMenuInicial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayMenuInicial.activeMenuButton = true;
        PlayGame.playGame = false;

    } 
}
