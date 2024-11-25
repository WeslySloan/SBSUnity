using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class Projectile : MonoBehaviour
    {
        public float speed = 3f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // ���� * �ӷ� * �ð�
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.CompareTag("Animal"))  // Tag .Animal ����̸�  
            {
                // �ڱ��ڽŰ� �浹�� ����� ���� ������Ʈ�� �ı��ض�
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
