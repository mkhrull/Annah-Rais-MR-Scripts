using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneSwitcher : MonoBehaviour
{
    public void moveHome()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - currentSceneIndex);
    }

    public void MoveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void btnTest()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }
}