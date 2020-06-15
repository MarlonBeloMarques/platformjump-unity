using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class PauseMenu : MonoBehaviour
    {
        public static bool GameIsPause = false;
        public GameObject MenuPauseUI;
        public bool startpause;

        // Update is called once per frame
        void Update()
        {
            if (startpause)
            {
                if (GameIsPause)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
            startpause = false;
        }

        public void Resume()
        {
            MenuPauseUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPause = false;
        }

        public void Pause()
        {
            MenuPauseUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPause = true;
        }

        public void StartPause(bool active)
        {
            startpause = active;
        }

        public void LoadMenu()
        {
            GameIsPause = false;
        }
    }
}