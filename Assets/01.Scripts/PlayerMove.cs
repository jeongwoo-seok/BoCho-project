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
        // 1. 사용자의 입력을 받아
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. 방향을 정하고
        Vector3 dir = new Vector3(h, 0, v);

        // 3. 카메라가 보는 방향을 기준으로 방향 재설정
        dir = Camera.main.transform.TransformDirection(dir);

        // 4. 정규화
        dir.Normalize();
        // 5. 그 방향으로 움직임
        if (cc.isGrounded == true)
        {
            yVelocity = 0;
        }


        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;
        cc.Move(dir * moveSpeed * Time.deltaTime);

    }
}
