using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearTrigger : MonoBehaviour
{
    public Animator bearAnimator; // Reference to the Bear_4's Animator

    void Start()
    {
        // Optionally, find the Animator component on Bear_4 if not assigned in the Inspector
        if (bearAnimator == null)
        {
            bearAnimator = GameObject.Find("Bear_4").GetComponent<Animator>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Example: Start the animation when the player interacts with the spear
        if (other.CompareTag("Player"))
        {
            bearAnimator.SetTrigger("StartAnimationTrigger"); // Trigger the Bear_4's animation
        }
    }
}
