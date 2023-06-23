using UnityEngine;
using UnityEngine.UI;

public class ItemCountController : MonoBehaviour
{
    public Text itemCountText;
    private int itemCount;

    private void Start()
    {
        itemCount = 0;
        UpdateItemCountText();
    }

    public void IncreaseItemCount()
    {
        itemCount++;
        UpdateItemCountText();
    }

    public void DecreaseItemCount()
    {
        itemCount--;
        UpdateItemCountText();
    }

    public void ResetItemCount()
    {
        itemCount = 0;
        UpdateItemCountText();
    }

    private void UpdateItemCountText()
    {
        itemCountText.text = "Item Count: " + itemCount.ToString();
    }
}