// C# Script
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    // Reference to the AudioSource component
    public AudioSource audioSource;

    // Track if audio is currently playing via this trigger
    private bool isAudioPlaying = false;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Toggle audio playback
            if (!isAudioPlaying)
            {
                audioSource.Play(); // Start playing audio
            }
            else
            {
                audioSource.Stop(); // Stop audio if it was already playing
            }

            // Update toggle state
            isAudioPlaying = !isAudioPlaying;
        }
    }
}