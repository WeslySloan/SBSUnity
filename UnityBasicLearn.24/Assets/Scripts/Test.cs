using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic
{
    public class Test : MonoBehaviour
    {
        public int testCount;

        public TempMyCode tempMyCode;

        // Start is called before the first frame update
        void Start()
        {
            testCount = 3;

            if (tempMyCode.ab < testCount)
            {
                Debug.Log($"temp의 값 : {tempMyCode.ab}, testCount의 값 : {testCount}");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }



    }

}