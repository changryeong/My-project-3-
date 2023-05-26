using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnInterval = 0.5f;
    public float bulletSpeed = 10f; // 추가: 총알 속도 변수

    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButton(0) && timer >= spawnInterval)
        {
            SpawnBullet();
            timer = 0f;
        }
    }

    private void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>(); // 추가: Rigidbody 컴포넌트 가져오기
        bulletRigidbody.velocity = transform.forward * bulletSpeed; // 총알 속도 설정
    }
}