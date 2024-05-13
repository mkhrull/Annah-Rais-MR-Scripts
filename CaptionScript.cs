using UnityEngine;
using TMPro;

public class CaptionScript : MonoBehaviour
{
    public TextMeshPro captionText; // Reference to the TextMeshPro object for displaying captions
    public float[] captionTimes; // Array to store the times at which captions should be displayed
    public string[] captions; // Array to store the corresponding captions

    private int currentCaptionIndex = 0; // Index to keep track of the current caption

    void Update()
    {
        float currentTime = Time.time; // Get the current time of the video playback

        // Check if there are more captions to display and if the current time is greater than or equal to the next caption time
        if (currentCaptionIndex < captionTimes.Length && currentTime >= captionTimes[currentCaptionIndex])
        {
            captionText.SetText(captions[currentCaptionIndex]); // Set the text of the TextMeshPro object to the current caption
            currentCaptionIndex++; // Increment the index to move to the next caption
        }
    }
}