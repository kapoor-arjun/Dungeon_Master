using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * 0.5f * Time.deltaTime);
    }
}