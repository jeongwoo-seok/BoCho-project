using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bombFactory;
    public GameObject bulletDongFactory;

    public Transform BulletDongPos;
    public Transform firePos;
    //던지는 파워
    public float throwPower = 2000;
    //총알효과
    public GameObject bulletEft;
    //총알파워
    public float bulletPower = 10;
    public float bulletDongPower = 50;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //2.폭탄공장에서 폭탄을 만든다.
            GameObject bullet = Instantiate(bombFactory);
            //3.만들어진 폭탄을 firePos에 넣는다
            bullet.transform.position = firePos.position;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            //5.카메라가 바라보는 방향으로 물리적인 힘을 가한다
            rb.AddForce(Camera.main.transform.forward * throwPower);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            //2.폭탄공장에서 폭탄을 만든다.
            GameObject dong = Instantiate(bulletDongFactory);
            //3.만들어진 폭탄을 firePos에 넣는다
            dong.transform.position = BulletDongPos.position;
            Rigidbody rb2 = dong.GetComponent<Rigidbody>();
            //5.카메라가 바라보는 방향으로 물리적인 힘을 가한다
            rb2.AddForce(transform.up * bulletDongPower);
        }
    }
}
