using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetsUiElementToSelectOnInteraction : MonoBehaviour
{
    [Header("Setup")]
    [SerializeField] private EventSystem eventSystem;
    [SerializeField] private Selectable elementToSelect;

    [Header("Visualization")]
    [SerializeField] private bool showVisualization;
    [SerializeField] private Color navigationColour = Color.cyan;

    private void OnDrawGizmos()
    {
        if (!showVisualization)
            return;

        if (elementToSelect == null)
            return;

        Gizmos.color = navigationColour;
        Gizmos.DrawLine(gameObject.transform.position, elementToSelect.gameObject.transform.position);
    }

    private void Reset()
    {
        eventSystem = FindObjectOfType<EventSystem>();

        if (eventSystem == null)
            Debug.Log("Did not find an Event System in your Scene.", this);
    }

    public void JumpToElement()
    {
        if (eventSystem == null)
            Debug.Log("This item has no event system referenced yet.", this);

        if (elementToSelect == null)
            Debug.Log("This should jump where?", this);

        eventSystem.SetSelectedGameObject(elementToSelect.gameObject);
    }

    public void JumpToElement(GameObject target) // overloaded the function so I can choose an element from the inspector
    {
        if (eventSystem == null)
            Debug.Log("This item has no event system referenced yet.", this);

        if (elementToSelect == null)
            Debug.Log("This should jump where?", this);

        eventSystem.SetSelectedGameObject(target);
    }
}