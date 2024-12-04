using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public int m_level = 0;


    // Start is called before the first frame update
    void Start()
    {

        // Resources 폴더에 저장한 오브젝트 불러오기

        string name = $"Level_{m_level}";

        GameObject level = Resources.Load("Level") as GameObject;
        Instantiate(level);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
