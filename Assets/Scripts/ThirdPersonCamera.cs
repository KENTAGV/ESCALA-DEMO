using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    [Header("Objetivo")]
    public Transform target; // Jugador

    [Header("Distancia y altura")]
    public float distance = 5f;
    public float height = 2f;

    [Header("Rotación")]
    public float mouseSensitivity = 3f;
    public float minY = -35f;
    public float maxY = 60f;

    [Header("Suavizado")]
    public float smoothSpeed = 10f;

    private float currentX = 0f;
    private float currentY = 20f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Input mouse
        currentX += Input.GetAxis("Mouse X") * mouseSensitivity;
        currentY -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        currentY = Mathf.Clamp(currentY, minY, maxY);

        // Rotación
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);

        // Posición deseada
        Vector3 direction = new Vector3(0, 0, -distance);
        Vector3 desiredPosition = target.position + Vector3.up * height + rotation * direction;

        // Movimiento suave
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(target.position + Vector3.up * height);
    }
}
