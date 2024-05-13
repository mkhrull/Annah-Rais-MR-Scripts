using UnityEngine;
using UnityEngine.UI;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject objectToToggle;
    private bool isActive = false;

    public void ToggleActiveState()
    {
        isActive = !isActive;
        if (isActive)
        {
            // Enable all parent GameObjects before enabling the child GameObject
            Transform parent = objectToToggle.transform.parent;
            while (parent != null)
            {
                parent.gameObject.SetActive(true);
                parent = parent.parent;
            }
        }
        objectToToggle.SetActive(isActive);
    }

    public void DisableGameObject()
    {
        objectToToggle.SetActive(false);
    }
}