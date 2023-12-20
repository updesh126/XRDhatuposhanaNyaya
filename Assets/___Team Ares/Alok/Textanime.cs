using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TextUpDownAnimation : MonoBehaviour
{
    public float amplitude = 0.1f; // Set the amplitude of the animation
    public float frequency = 1f; // Set the frequency of the animation

    private XRGrabInteractable grabInteractable;
    private Vector3 initialPosition;

    void Start()
    {
        // Get the XRGrabInteractable component
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Store the initial position of the object
        initialPosition = transform.position;
    }

    void Update()
    {
        // Check if the object is not being grabbed
        if (grabInteractable && !grabInteractable.isSelected)
        {
            // Calculate the vertical offset using a sine wave
            float yOffset = Mathf.Sin(Time.time * frequency) * amplitude;

            // Update the object's position with the vertical offset
            transform.position = initialPosition + new Vector3(0f, yOffset, 0f);
        }
    }
}

