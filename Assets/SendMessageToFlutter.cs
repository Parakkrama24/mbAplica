using UnityEngine;
using FlutterUnityIntegration;

public class SendMessageToFlutter : MonoBehaviour
{
    private UnityMessageManager messageManager;

    void Start()
    {
        // Get the UnityMessageManager component
        messageManager = GetComponent<UnityMessageManager>();

        if (messageManager == null)
        {
            Debug.LogError("UnityMessageManager not found on the GameObject.");
            return;
        }

        // Send a message to Flutter
        SendMessage();
    }

    void SendMessage()
    {
        string message = "Hello from Unity!";
        messageManager.SendMessageToFlutter(message);
    }
}
