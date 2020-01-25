using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;

    void Update()
    {
        transform.position = Player.position + Offset;
    }
}
