using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class SpawnAnimal : MonoBehaviour
    {
        [Header("���� ��ȯ ����")]
        public GameObject animalPrefab;
        public float spawnTime = 3f;
        private float checkTime = 0f;

        [Header("������ ��ȯ ����")]
        public GameObject bananaPrefab;
        public float itemSpawnTime = 3f;
        private float itemCheckTime = 0f;

        public int limitX = 20;

        

        // Start is called before the first frame update
        void Start()
        {
            Instantiate(animalPrefab);
        }

        // Update is called once per frame
        void Update()
        {
            // ��� �ð�

            SpawnAnimals();
            SpawnBanana();
        }

        private void SpawnAnimals()
        {
            checkTime += Time.deltaTime;

            if (checkTime >= spawnTime)
            {
                checkTime = 0f;

                int randomX = Random.Range(-limitX, limitX);

                Vector3 spawnPos = new Vector3(randomX, 0, 19);

                Instantiate(animalPrefab, spawnPos, animalPrefab.transform.rotation);
            }
        }

        private void SpawnBanana()
        {
            itemCheckTime += Time.deltaTime;

            if (itemCheckTime >= itemSpawnTime)
            {
                itemCheckTime = 0f;

                int randomX = Random.Range(-limitX, limitX);

                Vector3 spawnPos = new Vector3(randomX, 0, 0);

                Instantiate(bananaPrefab, spawnPos, animalPrefab.transform.rotation);
            }
        }
    }
}
