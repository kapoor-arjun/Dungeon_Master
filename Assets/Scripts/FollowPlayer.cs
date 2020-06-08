using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private float cameraOffset;
    public Transform Player;
    
    void Update()
    {
        transform.position = new Vector3(Player.position.x + cameraOffset, transform.position.y, transform.position.z);
    }
}