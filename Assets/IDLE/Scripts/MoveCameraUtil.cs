using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraUtil : MonoBehaviour
{
    public float speed = 10.0f;  // Speed of the camera movement

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");  // Get left-right input (A/D or left/right arrow)
        float verticalInput = Input.GetAxis("Vertical");  // Get up-down input (W/S or up/down arrow)

        // Create a new vector with the input data
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // Move the camera
        transform.position += movement * speed * Time.deltaTime;
    }
}
