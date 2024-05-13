using UnityEngine;

public class PlaySoundOnTopPress : MonoBehaviour
{
    public string topPartTag = "test";
    public AudioClip soundClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(topPartTag))
        {
            // Handle the interaction with the top part here
            audioSource.PlayOneShot(soundClip);
        }
    }
}