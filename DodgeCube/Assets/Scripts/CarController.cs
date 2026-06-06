using UnityEngine;

public class CarController : MonoBehaviour
{
    [Header("Car Settings")]
    public float speed = 10f;
    public float turnSpeed = 50f;

    private float moveInput;
    private float turnInput;

    void Update()
    {
        // Get player input
        moveInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");

        // Move the car forward/backward
        transform.Translate(Vector3.forward * moveInput * speed * Time.deltaTime);

        // Rotate the car left/right
        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
    }
}