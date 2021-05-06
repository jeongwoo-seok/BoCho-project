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
        //폭발효과 공장에서 폭발효과 생성
        GameObject explo = Instantiate(exploFactory);
        //생성된 폭발효과를 자기자신 위치에 위치시킨다
        explo.transform.position = transform.position;
        // 나자신 파괴
        //Destroy(gameObject);

        //3초있다가 파괴하자
        Destroy(gameObject);
    }
}
