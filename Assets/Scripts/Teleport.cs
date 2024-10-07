using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;           // Reference to XR Origin Rig's Transform
    public Transform destination;      // Reference to Receiver Portal's Transform
    private CharacterController cc;    // Reference to CharacterController

    void Start()
    {
        // Get the CharacterController from the XR Origin Rig if it exists
        cc = player.GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Teleport Triggered!");

            if (cc != null)
            {
                // If CharacterController exists, use it to move the player
                Vector3 moveDirection = destination.position - player.position;
                cc.enabled = false;  // Temporarily disable CharacterController to prevent conflicts
                cc.transform.position = destination.position;  // Set new position
                cc.enabled = true;   // Re-enable CharacterController after teleportation
            }
            else
            {
                // If no CharacterController, teleport the player by changing the Transform directly
                player.position = destination.position;
            }

            Debug.Log("Player Teleported to: " + player.position);
        }
    }
}


