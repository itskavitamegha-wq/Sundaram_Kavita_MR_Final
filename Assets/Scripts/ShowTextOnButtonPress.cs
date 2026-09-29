// Language: C#
// This script allows a button to display overlay text using TextMeshPro.

using UnityEngine;
using TMPro;          // Required to use TextMeshPro components
using UnityEngine.UI; // Required to use UI Button

public class ShowTextOnButtonPress : MonoBehaviour
{
    // Reference your TextMeshProUGUI component in the Inspector
    public TMP_Text overlayText;

    // The message that will appear when the button is clicked
    public string message = "Overlay Text Activated!";

    // This method will be called by the button's OnClick event
    public void ShowOverlayText()
    {
        if (overlayText != null)
        {
                          // Set the text message
            overlayText.gameObject.SetActive(true);    // Make sure text is visible
            Debug.Log("Overlay text shown successfully."); // Debug confirmation
        }
        else
        {
            Debug.LogWarning("overlayText is not assigned!");
        }
    }

    // Optional: Hide overlay text initially if required
    private void Start()
    {
        if (overlayText != null)
        {
            overlayText.gameObject.SetActive(false); // Start with overlay hidden
        }
    }
}