using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceInput : MonoBehaviour
{
    public void OnSpace(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameEvents.Instance.SpacePressed();
        }
    }
}
