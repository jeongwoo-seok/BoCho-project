using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRotate : MonoBehaviour
{
    // ȸ���ӷ�
    public float rotSpeed = 250;

    // ȸ����
    float rotX = 0;
    float rotY = 0;

    // ȸ�� ���� ����
    public bool useVertical = false;
    public bool useHorizontal = false;

    void Start()
    {

    }

    void Update()
    {
        // ���콺�� �����Ӱ��� �޾ƿ���
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        // ȸ�� ���� ����
        if (useVertical == true)
        {
            rotX += -my * rotSpeed * Time.deltaTime;
        }
        if (useHorizontal == true)
        {
            rotY += mx * rotSpeed * Time.deltaTime;
        }

        // 90 ~ -90�� ����
        rotX = Mathf.Clamp(rotX, -90, 90);

        // ��ü ȸ��
        transform.localEulerAngles = new Vector3(rotX, rotY, 0);
    }
}
