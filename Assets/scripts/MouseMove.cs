using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float sensitivity = 500f;
    public float rotationX;
    public float rotationY;

    void Start()
    {

    }

    void Update()
    {
        float mouseMoveX = Input.GetAxis("Mouse X");
        float mouseMoveY = Input.GetAxis("Mouse Y");

        rotationY += mouseMoveX * sensitivity * Time.deltaTime;
        rotationX -= mouseMoveY * sensitivity * Time.deltaTime;  // rotationX�� ��ȣ ����

        if (rotationX < -30f)
        {
            rotationX = -30f;
        }

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);  // transform.eulerAngles �ùٸ��� ����
    }
}