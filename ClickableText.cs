using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableText : MonoBehaviour, IPointerClickHandler
{
    // Define the URL or action you want to perform when the text is clicked
    public string linkURL = "https://www.facebook.com/AnnahRaisLonghouseHomestay/photos";

    public void OnPointerClick(PointerEventData eventData)
    {
        // Handle the click event here
        // You can open a link, perform an action, or whatever you want
        Application.OpenURL(linkURL); // Example: Open a URL
    }
}