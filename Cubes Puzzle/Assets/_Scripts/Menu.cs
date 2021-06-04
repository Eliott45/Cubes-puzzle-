using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Scripts
{
    public class Menu : MonoBehaviour
    {
        [Header("Set in Inspector")]
        [SerializeField] private AudioSource music;
        [SerializeField] private GameObject uiOptons;
        [SerializeField] private GameObject uiMenu;
        [SerializeField] private GameObject uiCredits;
        
        public void StartGame()
        {
            SceneManager.LoadScene("lvl1");
            DontDestroyOnLoad(music);
        }

        public void ShowOptions()
        {
            uiMenu.SetActive(false);
            uiOptons.SetActive(true);
        }

        public void HideOptions()
        {
            uiMenu.SetActive(true);
            uiOptons.SetActive(false);
        }

        public void ShowCredits()
        {
            uiMenu.SetActive(false);
            uiCredits.SetActive(true);
        }

        public void HideCredits()
        {
            uiMenu.SetActive(true);
            uiCredits.SetActive(false);
        }
          
        public void Exit()
        {
            Application.Quit();
        }
        
        public void SetFullscreen(bool isFullscreen)
        {
            Screen.fullScreen = isFullscreen;
        }

    }
}
