using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxAni : MonoBehaviour
{
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        // animator 변수에 (나 자신의 스크립트 오브젝트의 위치)컴포넌트를 찾아서 넣어라.
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            bool current = animator.GetBool("Square");
            animator.SetBool("Square", !current);
        }
    }
}
