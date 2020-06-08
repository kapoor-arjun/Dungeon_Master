using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private float _horizontalInput;

    public Animator animator;

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", _horizontalInput);
        if(_horizontalInput >= 0)
        {
            transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);
        }
    }
}