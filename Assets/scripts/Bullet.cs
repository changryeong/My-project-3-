using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bulletLifetime = 2f;
    public bool isClone = false; // 복제된 총알인지 여부를 나타내는 플래그 변수

    private void Start()
    {
        if (isClone)
        {
            // 일정 시간 후에 총알을 제거하기 위한 Invoke 함수 호출
            Invoke("DestroyBullet", bulletLifetime);
        }
    }

    private void Update()
    {
        if (isClone)
        {
            // 총알을 정해진 속도로 이동시킴
            transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isClone)
        {
            // 총알이 다른 물체와 충돌했을 때 호출되는 함수
            // 여기에 충돌에 대한 추가적인 로직을 구현할 수 있음
            // 예를 들어, 충돌한 물체에 대한 피해를 입히는 등의 동작을 추가할 수 있음

            // 총알을 제거함
            Destroy(gameObject);
        }
    }

    private void DestroyBullet()
    {
        // 총알을 제거함
        Destroy(gameObject);
    }
}