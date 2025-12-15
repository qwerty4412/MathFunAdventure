using UnityEngine;

public class Movement2 : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(horizontalMove, 0, 0);
        moveDirection.Normalize();
        transform.Translate(moveDirection * _movementSpeed * Time.deltaTime);
    }
}
