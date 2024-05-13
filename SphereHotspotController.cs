using UnityEngine;

public class SphereHotspotController : MonoBehaviour
{
    public GameObject hotspotPanel; // The panel that displays the hotspot text
    public string hotspotText; // The text that appears when the user interacts with the hotspot
    public Vector2 hotspotPosition; // The position on the sphere where the hotspot appears (in UV coordinates)

    private bool hotspotVisible; // Whether or not the hotspot is currently visible

    void Start()
    {
        hotspotVisible = false;
        hotspotPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0) && hotspotVisible)
        {
            hotspotVisible = false;
            hotspotPanel.SetActive(false);
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !hotspotVisible)
        {
            hotspotVisible = true;
            hotspotPanel.SetActive(true);
            hotspotPanel.GetComponentInChildren<UnityEngine.UI.Text>().text = hotspotText;
            hotspotPanel.transform.position = new Vector3(hotspotPosition.x, hotspotPosition.y, 0.0f);
        }
    }

    void OnMouseExit()
    {
        if (hotspotVisible)
        {
            hotspotVisible = false;
            hotspotPanel.SetActive(false);
        }
    }
}
