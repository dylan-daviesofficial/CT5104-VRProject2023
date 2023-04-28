using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class GEvent : UnityEvent { };

public class GazeEvent : MonoBehaviour
{

    public GEvent onLook;
 
}
