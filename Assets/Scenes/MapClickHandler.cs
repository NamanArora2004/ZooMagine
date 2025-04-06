using UnityEngine;

public class MapClickHandler : MonoBehaviour
{
    public GameObject[] buttons; // Array to store the buttons

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detect left mouse click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Cast a ray from the camera to the mouse position
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // Check if the ray hits something
            {
                if (hit.transform == transform) // Check if the clicked object is the map
                {
                    ShowButtons();
                }
            }
        }
    }

    void ShowButtons()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true); // Activate each button
        }
    }
}
