using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falldown : MonoBehaviour
{
    // 이동할 다음 맵의 이름
    public string nextSceneName = "Stage1";

    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 Player인 경우
        if (other.CompareTag("Player"))
        {
            // 다음 맵으로 이동
            SceneManager.LoadScene("Stage1");
        }
    }
}