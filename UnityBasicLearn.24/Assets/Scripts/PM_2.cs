using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class PM_2 : MonoBehaviour
    {
        public float speed = 5.0f;
        public float speedModifier = 0.2f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if( transform.position.x < -20 )
            {
                transform.position = new Vector3(-20, transform.position.y, transform.position.z);
            }

            if (transform.position.x > 20)
            {
                transform.position = new Vector3(20, transform.position.y, transform.position.z);
            }

            float horiontalInput = Input.GetAxis("Horizontal");
            Debug.Log($"입력받은 수평 값 : {horiontalInput}");
            transform.position = transform.position + Vector3.right * horiontalInput * speed * Time.deltaTime;

            //float horizontal = Input.GetAxis("Horizontal");  // Horizontal

            //transform.Rotate(Vector3.up, turnSpeed * horizontal * Time.deltaTime);
        }
    }
}
