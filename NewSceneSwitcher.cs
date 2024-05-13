using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneSwitcher : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // This function loads a specified number of scenes ahead
    public void moveScenes(int count)
    {
        count++;
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + count;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    // This function loads a specified number of scenes behind
    public void moveBackScenes(int count)
    {
        count--;
        int previousSceneIndex = SceneManager.GetActiveScene().buildIndex - count;
        if (previousSceneIndex >= 0)
        {
            SceneManager.LoadScene(previousSceneIndex);
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // This function is called when a button is pressed to move forward a certain number of scenes
    public void OnMoveForwardButtonPress()
    {
        moveScenes(1);
    }

    // This function is called when a button is pressed to move backward a certain number of scenes
    public void OnMoveBackwardButtonPress()
    {
        moveBackScenes(1);
    }
}
