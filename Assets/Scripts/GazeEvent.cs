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
    public GEvent onTimerFinish;

    float timer = 0;
    public float lookTime = 3;
    bool lookedThisFrame = false;

    public void LateUpdate()
    {
        if (lookedThisFrame)
        {
            timer += Time.deltaTime;
            if (timer > lookTime) onTimerFinish.Invoke();

        }
        else timer = 0;
        lookedThisFrame = false;

    }
    
    public void GazingThisFrame()
    {
        lookedThisFrame = true;
    }
    
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
