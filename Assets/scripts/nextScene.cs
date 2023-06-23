using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public string Stage1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                SceneManager.LoadScene(Stage1);
        }
    }
}