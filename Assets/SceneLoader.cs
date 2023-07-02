using SmartPoint.Components;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        var eventTrigger = GetComponent<EventTrigger>();
        var entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) => OnPointerClickDelegate((PointerEventData)data));
        eventTrigger.triggers.Add(entry);
    }

    public void OnPointerClickDelegate(PointerEventData data)
    {
        if (!string.IsNullOrEmpty(tapSE))
        {
            // Assuming AudioPlayer is a class with a static method PlayEffect
            AudioPlayer.PlayEffect(tapSE, 1.0f);
        }

        // Assuming SceneBrowser is a class with a static method Open
        //SceneBrowser.Open(scenePath, true);
    }

    public string scenePath;

    public string webViewURL;

    public string tapSE;
}
