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
    private void OnCollisionEnter(Collision other); //충돌 시 이벤트
    {
      Destroy(other.gameObject); //너 소멸
      Destroy(gameObject); //나 소멸
    }       
}
