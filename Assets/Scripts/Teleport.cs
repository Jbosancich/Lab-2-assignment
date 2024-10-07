using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;          // Reference to XR Origin Rig's Transform
    public Transform destination;     // Reference to Receiver Portal's Transform

    // Trigger detection when the player enters the Portal Red
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Teleport the player (XR Origin Rig) to the destination (Receiver Portal)
            player.position = destination.position;
        }
    }
}

