using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float sideSpeed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * sideSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Obstacle"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}