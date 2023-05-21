using UnityEngine;

public class ItemCan : MonoBehaviour
{
    public float rotateSpeed;
    private ItemCountController itemCountController;

    private void Start()
    {
        itemCountController = FindObjectOfType<ItemCountController>();
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            itemCountController.IncreaseItemCount();
            gameObject.SetActive(false);
        }
    }
}