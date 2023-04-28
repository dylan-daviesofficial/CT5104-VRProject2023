using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeObject : MonoBehaviour
{
    public   float hideSize = 0;
    public float showSize = 1;
    public AnimationCurve showRate;


    void Update()
    {
        Vector3 vectorA = Camera.main.transform.forward;

        Vector3 vectorB = (transform.position - Camera.main.transform.position).normalized;

        float dotProduct = Vector3.Dot(vectorA, vectorB);

        float lerpVal = Mathf.Max(0, dotProduct);

        transform.localScale = Vector3.one *  Mathf.Lerp(0,1, showRate.Evaluate(lerpVal));
    }
}
