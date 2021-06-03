using System;
using UnityEngine;

namespace _Scripts
{
    public class Button : MonoBehaviour
    {
        [Header("Set in Inspector")] 
        [SerializeField] private GameObject[] cubes;
        [SerializeField] private Material normal;
        [SerializeField] private Material transparent;

        [Header("Set is Dynamically")]
        public bool canPush = true;
        
        private void OnTriggerEnter(Collider other)
        {
            if(!canPush) return;
            
            foreach (var cube in cubes)
            {
                cube.GetComponent<BoxCollider>().isTrigger = !cube.GetComponent<BoxCollider>().isTrigger;

                cube.GetComponent<Renderer>().material = cube.GetComponent<BoxCollider>().isTrigger ? transparent : normal;
            }
        }

        public void ChangeAbilityToPush(bool push)
        {
            canPush = push;
            GetComponent<Renderer>().material = canPush ? normal : transparent;
        }
    }
}
