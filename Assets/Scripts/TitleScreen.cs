using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    private void Update()
    {
        if (Gamepad.current != null && 
            Gamepad.current.leftTrigger.wasPressedThisFrame && Gamepad.current.rightTrigger.wasPressedThisFrame ||
            Keyboard.current.anyKey.wasPressedThisFrame)
        {
            LoadMainMenu();
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
