using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoEndTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName;

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoEndReached;
    }

    private void OnVideoEndReached(VideoPlayer vp)
    {
        // Load the next scene when the video ends
        SceneManager.LoadScene(nextSceneName);
    }
}