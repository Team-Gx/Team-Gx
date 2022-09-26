using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public GameObject bulletFactory;
    public GameObject firePosition;

   
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //��ư ���� �� ���̾�(�߻�)
        {
            GameObject bullet = Instantiate(bulletFactory); //�Ѿ� ����
            bullet.transform.position = firePosition.transform.position; //�Ѿ� �߻��Ѵ�(�Ѿ� �ѱ� ��ġ�� ����)
        }
    }
}
