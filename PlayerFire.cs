using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public GameObject bulletFactory;
    public GameObject firePosition;

   
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //버튼 누를 시 파이어(발사)
        {
            GameObject bullet = Instantiate(bulletFactory); //총알 생성
            bullet.transform.position = firePosition.transform.position; //총알 발사한다(총알 총구 위치로 놓기)
        }
    }
}
