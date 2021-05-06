using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController cc;
    int moveSpeed = 7;
    float gravity = -9.8f;
    float hp = 100;
    float yVelocity = 0;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 1. ������� �Է��� �޾�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. ������ ���ϰ�
        Vector3 dir = new Vector3(h, 0, v);

        // 3. ī�޶� ���� ������ �������� ���� �缳��
        dir = Camera.main.transform.TransformDirection(dir);

        // 4. ����ȭ
        dir.Normalize();
        // 5. �� �������� ������
        if (cc.isGrounded == true)
        {
            yVelocity = 0;
        }


        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;
        cc.Move(dir * moveSpeed * Time.deltaTime);

    }
}
