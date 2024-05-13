using UnityEngine;
using TMPro;

public class SubtitleScript : MonoBehaviour
{
    public TextMeshPro captionText;
    public float[] captionTimes;
    public string[] captions;

    private int currentCaptionIndex = 0;
    private float startTime; // Store the time when the scene starts

    private void Start()
    {
        startTime = Time.time; // Record the starting time of the scene
    }

    private void Update()
    {
        float currentTime = Time.time - startTime; // Calculate time relative to scene start

        if (currentCaptionIndex < captionTimes.Length && currentTime >= captionTimes[currentCaptionIndex])
        {
            captionText.SetText(captions[currentCaptionIndex]);
            currentCaptionIndex++;
        }
    }

    // You can call this method when you change scenes to reset the captions
    public void ResetCaptions()
    {
        currentCaptionIndex = 0;
        startTime = Time.time; // Reset the start time
    }
}
