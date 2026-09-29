// C# Script
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayVideoButton : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign this in the Inspector
    public Button playButton;       // Assign your UI button in the Inspector

    void Start()
    {
        // Ensure the video does not play automatically on start
        videoPlayer.playOnAwake = false;

        // Add listener for button click
        playButton.onClick.AddListener(PlayVideo);
    }

    void PlayVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }
}