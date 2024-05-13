using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class OpenDialogOnClick : MonoBehaviour
{
    public GameObject dialogPrefab;

    private void Start()
    {
        GetComponent<Interactable>().OnClick.AddListener(OpenDialog);
    }

    private void OpenDialog()
    {
        Instantiate(dialogPrefab);
    }
}