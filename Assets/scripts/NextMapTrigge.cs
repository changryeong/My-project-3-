using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falldown : MonoBehaviour
{
    // �̵��� ���� ���� �̸�
    public string nextSceneName = "Stage1";

    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ������Ʈ�� Player�� ���
        if (other.CompareTag("Player"))
        {
            // ���� ������ �̵�
            SceneManager.LoadScene("Stage1");
        }
    }
}