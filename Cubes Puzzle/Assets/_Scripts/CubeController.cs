using UnityEngine;

namespace _Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class CubeController : MonoBehaviour
    {
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
    }
}
