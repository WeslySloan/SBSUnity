using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic
{
    public class PlayerMove : MonoBehaviour
    {
        public float speed = 5f;
        public float speedModifier = 0.2f;

        public int turnSpeed = 45;

        // Start is called before the first frame update
        void Start()
        {
            
        }

     
        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");  // Horizontal
            float vertical    = Input.GetAxis("Vertical");     // Vertial

            transform.Translate(speed * vertical * Time.deltaTime * Vector3.forward);
            transform.Rotate(Vector3.up, turnSpeed * horizontal * Time.deltaTime);
  
        }
    }
}
