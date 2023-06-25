using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player; // Player 오브젝트의 Transform 컴포넌트를 받을 변수

    private void Update()
    {
        // Player 오브젝트의 위치를 추적하여 Sphere 오브젝트를 해당 위치로 이동시킴
        transform.position = Player.position;
    }
}