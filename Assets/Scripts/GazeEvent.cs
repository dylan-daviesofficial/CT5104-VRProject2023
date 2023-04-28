using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GEvent : UnityEvent { };

public class GazeEvent : MonoBehaviour
{

    public GEvent onLook;
    {
        SceneManager.LoadScene("VRSceneCreepy");
    }
    
      
    
}
