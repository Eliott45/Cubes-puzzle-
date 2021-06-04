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
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;
            try
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            catch 
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
