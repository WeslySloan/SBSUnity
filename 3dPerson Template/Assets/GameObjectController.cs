using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectController : MonoBehaviour
{
    [System.Serializable]
    public class TransformData
    {
        public GameObject targetObject;
        public bool isTrigger = false;
        public bool changeRotation = false;
        public Vector3 rotation;

        public float lerpSpeed = 1.0f;
    }

    public List<TransformData> datas;

    private void Update()
    {
        foreach(var data in datas)
        {
            ApplyTransform(data);
        }
    }

    void ApplyTransform(TransformData data)
    {
        Transform targetTransform = data.targetObject.transform;

        if(data.isTrigger)
        {
            if(data.changeRotation)
            {
                Quaternion targetRotation = Quaternion.Euler(data.rotation);
                targetTransform.rotation = Quaternion.Lerp(targetTransform.rotation, targetRotation, data.lerpSpeed * Time.deltaTime);
            }
        }
    }
}
