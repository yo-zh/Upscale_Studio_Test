using UnityEngine;
using UnityEngine.InputSystem;

public class InGameMenu : MonoBehaviour
{
    [SerializeField] private Canvas MainMenuCanvas;

    private void Start()
    {
        MainMenuCanvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Gamepad.current != null &&
            Gamepad.current.startButton.wasPressedThisFrame ||
            Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            MainMenuCanvas.gameObject.SetActive(!MainMenuCanvas.gameObject.activeSelf);
        }
    }
}
