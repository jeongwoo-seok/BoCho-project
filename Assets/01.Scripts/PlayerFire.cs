using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bombFactory;
    public GameObject bulletDongFactory;

    public Transform BulletDongPos;
    public Transform firePos;
    //������ �Ŀ�
    public float throwPower = 2000;
    //�Ѿ�ȿ��
    public GameObject bulletEft;
    //�Ѿ��Ŀ�
    public float bulletPower = 10;
    public float bulletDongPower = 50;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //2.��ź���忡�� ��ź�� �����.
            GameObject bullet = Instantiate(bombFactory);
            //3.������� ��ź�� firePos�� �ִ´�
            bullet.transform.position = firePos.position;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            //5.ī�޶� �ٶ󺸴� �������� �������� ���� ���Ѵ�
            rb.AddForce(Camera.main.transform.forward * throwPower);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            //2.��ź���忡�� ��ź�� �����.
            GameObject dong = Instantiate(bulletDongFactory);
            //3.������� ��ź�� firePos�� �ִ´�
            dong.transform.position = BulletDongPos.position;
            Rigidbody rb2 = dong.GetComponent<Rigidbody>();
            //5.ī�޶� �ٶ󺸴� �������� �������� ���� ���Ѵ�
            rb2.AddForce(transform.up * bulletDongPower);
        }
    }
}
