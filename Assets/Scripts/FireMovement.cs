using UnityEngine;

public class FireMovement : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Fire Instantiated");
    }

    private void Update()
    {
        transform.Translate(new Vector3(0, -2, 0) * 2f * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Explodable>().explode();
        }
    }
}