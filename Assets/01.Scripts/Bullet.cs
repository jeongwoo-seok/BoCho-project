using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject exploFactory;

    void Start()
    {
        
    }
    
        
    private void OnCollisionEnter(Collision collision)
    {
        //����ȿ�� ���忡�� ����ȿ�� ����
        GameObject explo = Instantiate(exploFactory);
        //������ ����ȿ���� �ڱ��ڽ� ��ġ�� ��ġ��Ų��
        explo.transform.position = transform.position;
        // ���ڽ� �ı�
        //Destroy(gameObject);

        //3���ִٰ� �ı�����
        Destroy(gameObject);
    }
}
