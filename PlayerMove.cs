using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 5; //인스펙터 공개 스피드 조절

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //가로축이라 x에 할당
        float v = Input.GetAxis("Vertical"); //세로축이라 y에 할당

        Vector3 dir = new Vector3(h, v, 0); //x, y에 대하여 h, v 할당 되므로 이렇게 성립 가능
        transform.position += dir * speed * Time.deltaTime; // 이동에 대한 코드 정립

    }
}
