using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 5; //�ν����� ���� ���ǵ� ����

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //�������̶� x�� �Ҵ�
        float v = Input.GetAxis("Vertical"); //�������̶� y�� �Ҵ�

        Vector3 dir = new Vector3(h, v, 0); //x, y�� ���Ͽ� h, v �Ҵ� �ǹǷ� �̷��� ���� ����
        transform.position += dir * speed * Time.deltaTime; // �̵��� ���� �ڵ� ����

    }
}
