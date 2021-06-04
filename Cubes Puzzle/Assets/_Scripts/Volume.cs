using UnityEngine;
using UnityEngine.Audio;

namespace _Scripts
{
    public class Volume : MonoBehaviour
    {
        [SerializeField] private AudioMixer audioMixer;

        public void SetVolume(float volume)
        {
            audioMixer.SetFloat("Volume", volume);
        }
    }
}
