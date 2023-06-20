using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[CreateAssetMenuAttribute]
public class EventCameraTable : ScriptableObject
{
    public GameObject curve; // EventCameraCurveTable
    public GameObject[] table; // EventCameraData[]

    public GameObject get_Item(int index) // EventCameraData
    {
        return null;
    }

    public EventCameraTable()
    {

    }
}