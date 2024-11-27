using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class Pizza : MonoBehaviour, IitemCollectable
    {
        public void Interact()
        {
            Debug.Log("피자를 먹었습니다.");
        }
    }
}
