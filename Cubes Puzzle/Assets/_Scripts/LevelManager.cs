using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts
{
    public class LevelManager : MonoBehaviour
    {
        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
            if (Input.GetKey(KeyCode.Q))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("MainMenu");
                Destroy(GameObject.Find("Music"));
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;

            var countLevel = SceneManager.GetActiveScene().buildIndex + 1;
            
            if (countLevel < 6)
            {
                SceneManager.LoadScene(countLevel);
            }
            else
            {
                Destroy(GameObject.Find("Music"));
                SceneManager.LoadScene("MainMenu");
            }
            
        }
    }
}
