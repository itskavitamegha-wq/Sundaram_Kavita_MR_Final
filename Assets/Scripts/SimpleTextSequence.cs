// Language: C#
// Attach this script to any GameObject.
// Assign a TextMeshProUGUI component and a list of texts in the Inspector.

using UnityEngine;
using TMPro;
using System.Collections;

public class SimpleTextSequence : MonoBehaviour
{
    public TextMeshProUGUI tmpText;      // The TMP text component
    public string[] messages;            // List of texts to show sequentially
    public float delaySeconds = 2f;      // Time each text stays visible

    void Start()
    {
        if (tmpText != null && messages.Length > 0)
        {
            StartCoroutine(ShowTexts());
        }
    }

    private IEnumerator ShowTexts()
    {
        foreach (var message in messages)
        {
            tmpText.text = message;            // Set text
            yield return new WaitForSeconds(delaySeconds); // Wait
        }
        tmpText.text = ""; // Optional: Clear text after completion
    }
}