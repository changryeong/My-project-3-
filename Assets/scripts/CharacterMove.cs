using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMove : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private CharacterController characterController;
    private float moveSpeed = 10f;
    private float jumpSpeed = 10f;
    private float gravity = -20f;
    private float yVelocity = 0f;

    private Dictionary<GameObject, Vector3> initialObjectPositions;
    private ItemCountController itemCountController;

    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        characterController = GetComponent<CharacterController>();
        itemCountController = FindObjectOfType<ItemCountController>();

        SaveInitialObjectPositions();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(h, 0, v);
        moveDirection = Camera.main.transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

        if (characterController.isGrounded)
        {
            yVelocity = 0f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpSpeed;
            }
        }

        yVelocity += gravity * Time.deltaTime;
        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * Time.deltaTime);

        if (transform.position.y < -10f)
        {
            ResetMapToInitialState();
            ReactivateItemCans();
        }
    }

    void SaveInitialObjectPositions()
    {
        initialObjectPositions = new Dictionary<GameObject, Vector3>();

        // ��� ������ ������Ʈ�� �ʱ� ��ġ�� �����մϴ�.
        ItemCan[] itemCans = FindObjectsOfType<ItemCan>();
        foreach (ItemCan itemCan in itemCans)
        {
            initialObjectPositions[itemCan.gameObject] = itemCan.transform.position;
        }
    }

    void ResetMapToInitialState()
    {
        // �÷��̾� ��ġ�� ȸ���� �ʱ� ���·� �����մϴ�.
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        yVelocity = 0f;

        // ������ ������ �ʱ�ȭ�մϴ�.
        itemCountController.ResetItemCount();

       
      
    }


    void ReactivateItemCans()
    {
        foreach (KeyValuePair<GameObject, Vector3> pair in initialObjectPositions)
        {
            GameObject itemObject = pair.Key;
            itemObject.SetActive(true);
        }
    }

}