using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using SmartPoint.AssetAssistant;

namespace Dpr
{
    public class LogSender : SingletonMonoBehaviour<LogSender>
    {
        private string _webhookUrl;

        public void Init(Sequencer sequencer, string webhookUrl)
        {
            _webhookUrl = webhookUrl;
        }

        public void Log(string message)
        {
            // Output to the Unity console
            Debug.Log(message);

            if (UnityEditor.EditorApplication.isPlaying && StartupSettings.webhookInEditMode)
            {
                // Send to the webhook
                StartCoroutine(SendToWebhook(message));
            }
        }

        private IEnumerator SendToWebhook(string message)
        {
            string json = "{\"content\": \"" + message + "\"}";
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);

            using (UnityWebRequest www = new UnityWebRequest(_webhookUrl, "POST"))
            {
                www.uploadHandler = new UploadHandlerRaw(bodyRaw);
                www.downloadHandler = new DownloadHandlerBuffer();
                www.SetRequestHeader("Content-Type", "application/json");

                yield return www.SendWebRequest();
            }
        }
    }
}
