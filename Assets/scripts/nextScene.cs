using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player; // Player ������Ʈ�� Transform ������Ʈ�� ���� ����

    private void Update()
    {
        // Player ������Ʈ�� ��ġ�� �����Ͽ� Sphere ������Ʈ�� �ش� ��ġ�� �̵���Ŵ
        transform.position = Player.position;
    }
}