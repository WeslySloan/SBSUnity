using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class Pizza : MonoBehaviour, IitemCollectable
    {
        public void Interact()
        {
            Debug.Log("���ڸ� �Ծ����ϴ�.");
        }
    }
}
