using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenuInicial : MonoBehaviour {

    public GameObject audio;
    public static bool activeMenuButton = false;

    private void playMenuInicial()
    {
        SceneManager.LoadScene("game");
        activeMenuButton = true;
        audio.GetComponent<AudioSource>().Play();
        DontDestroyOnLoad(audio);
    }
}
