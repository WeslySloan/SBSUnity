using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Protoype2
{
    public class Animal : MonoBehaviour
    {
        public float speed = 3.0f;
        public float speedModifier = 0.2f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

            transform.position = transform.position + Vector3.forward * -1 * speed * Time.deltaTime;


        }
    }
}
