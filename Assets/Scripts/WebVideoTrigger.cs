// C#
using UnityEngine;
using UnityEngine.Video;

public class WebVideoTrigger : MonoBehaviour
{
    // Assign the VideoPlayer component in the Inspector
    public VideoPlayer videoPlayer;

    // Example: Trigger video on player entering a collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoPlayer != null && !videoPlayer.isPlaying)
            {
                // Start streaming video from URL
                videoPlayer.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (videoPlayer != null && videoPlayer.isPlaying)
            {
                videoPlayer.Stop();
            }
        }
    }

    // Optional: public method for UI button trigger
    public void PlayWebVideo()
    {
        if (videoPlayer != null && !videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }
}