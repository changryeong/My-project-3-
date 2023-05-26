using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bulletLifetime = 2f;
    public bool isClone = false; // ������ �Ѿ����� ���θ� ��Ÿ���� �÷��� ����

    private void Start()
    {
        if (isClone)
        {
            // ���� �ð� �Ŀ� �Ѿ��� �����ϱ� ���� Invoke �Լ� ȣ��
            Invoke("DestroyBullet", bulletLifetime);
        }
    }

    private void Update()
    {
        if (isClone)
        {
            // �Ѿ��� ������ �ӵ��� �̵���Ŵ
            transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isClone)
        {
            // �Ѿ��� �ٸ� ��ü�� �浹���� �� ȣ��Ǵ� �Լ�
            // ���⿡ �浹�� ���� �߰����� ������ ������ �� ����
            // ���� ���, �浹�� ��ü�� ���� ���ظ� ������ ���� ������ �߰��� �� ����

            // �Ѿ��� ������
            Destroy(gameObject);
        }
    }

    private void DestroyBullet()
    {
        // �Ѿ��� ������
        Destroy(gameObject);
    }
}