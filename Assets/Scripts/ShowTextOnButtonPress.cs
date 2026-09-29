// Language: C#
// This script starts an automatic text sequence when a button is pressed once.

using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowTextOnButtonPress : MonoBehaviour
{
    // Reference your TextMeshProUGUI component in the Inspector
    public TMP_Text overlayText;

    // The messages that will appear in sequence
    public string[] messages;

    // How long each message stays on screen
    public float timeBetweenMessages = 2f;

    // This method will be called by the button's OnClick event
    public void ShowOverlayText()
    {
        if (overlayText != null)
        {
            // Start the automatic text sequence
            StartCoroutine(PlayTextSequence());

            Debug.Log("Text sequence started.");
        }
        else
        {
            Debug.LogWarning("overlayText is not assigned!");
        }
    }

    // Plays each message automatically
    private IEnumerator PlayTextSequence()
    {
        // Make sure the text is visible
        overlayText.gameObject.SetActive(true);

        // Go through each message
        foreach (string message in messages)
        {
            overlayText.text = message;

            // Wait before showing the next message
            yield return new WaitForSeconds(timeBetweenMessages);
        }

        // Hide the text after the sequence is finished
        overlayText.gameObject.SetActive(false);
    }

    // Hide overlay text initially
    private void Start()
    {
        if (overlayText != null)
        {
            overlayText.gameObject.SetActive(false);
        }
    }
}