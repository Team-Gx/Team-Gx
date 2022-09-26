using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        Vector3 dir = Vector3.down;

        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision other); //�浹 �� �̺�Ʈ
    {
      Destroy(other.gameObject); //�� �Ҹ�
      Destroy(gameObject); //�� �Ҹ�
    }       
}
