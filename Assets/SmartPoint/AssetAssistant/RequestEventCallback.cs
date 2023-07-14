using System;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    public delegate void RequestEventCallback(RequestEventType requestEventType, string name, UnityEngine.Object content);
}
