using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GazeRaycast : MonoBehaviour
{

    float rayDistance = 20;

    RaycastHit hit;

    Color debugRayColor = Color.red;
    Color debugRayFail = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            Debug.DrawRay(transform.position, transform.forward * Vector3.Distance(transform.position, hit.point), debugRayColor);
            if (hit.transform.TryGetComponent(out GazeEvent i))
            {
                i.onLook.Invoke();
            }
        
        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * rayDistance, debugRayFail);

        }
    }
}
