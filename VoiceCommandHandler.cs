using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class VoiceCommandHandler : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private string launchCommand = "Annahrais"; // Change this to your desired voice command

    private void Start()
    {
        // Initialize the keyword recognizer with the launch command
        keywordRecognizer = new KeywordRecognizer(new string[] { launchCommand });

        // Register a callback for recognized keywords
        keywordRecognizer.OnPhraseRecognized += OnKeywordRecognized;

        // Start the keyword recognizer
        keywordRecognizer.Start();
    }

    private void OnKeywordRecognized(PhraseRecognizedEventArgs args)
    {
        if (args.text == launchCommand)
        {
            // Launch your app here
            StartMyApp(); // Implement this method
        }
    }

    private void StartMyApp()
    {
        // Implement the logic to start your app here
        // This could include loading a specific scene or initializing your app's main functionality
        // For example, you can load a scene using SceneManager.LoadScene("YourSceneName");
            SceneManager.LoadScene("FirstScene");
    }
}
