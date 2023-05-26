using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeParticleTransitioner : MonoBehaviour
{
    int counter = 0;
    public Transform player;
    public Transform[] positions;

    public Animator fadeController;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            fadeController.SetTrigger("Fade");
        }
    }

    public void ChangePosition()
    {
        counter = (counter + 1) % positions.Length;

        Transform i = positions[counter];

        player.SetPositionAndRotation(i.position, i.rotation);
    }


}
