using System;
using UnityEngine;

namespace _Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class CubeController : MonoBehaviour
    {
        [Header("Set in Inspector")]
        [SerializeField] private KeyCode keyOne;
        [SerializeField] private KeyCode keyTwo;
        [SerializeField] private Vector3 moveDirection;

        private Rigidbody _rigid;
        
        private void Awake()
        {
            _rigid = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (Input.GetKey(keyOne))
            {
                _rigid.velocity -= moveDirection;
            }

            if (Input.GetKey(keyTwo))
            {
                _rigid.velocity += moveDirection;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Cube")) return;
            SetAbilityToPush(false);
        }

        private void OnTriggerExit(Collider other)
        {
            if (!other.CompareTag("Cube")) return;
            SetAbilityToPush(true);
        }

        private static void SetAbilityToPush(bool can)
        {
            foreach (var button in FindObjectsOfType<Button>())
            {
                button.ChangeAbilityToPush(can);
            }
        }
    }
}
