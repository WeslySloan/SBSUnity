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
                Debug.Log($"temp�� �� : {tempMyCode.ab}, testCount�� �� : {testCount}");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }



    }

}