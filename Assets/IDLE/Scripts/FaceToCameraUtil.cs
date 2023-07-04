using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FaceToCameraUtil : MonoBehaviour
{
    void Update()
    {
        // Ensure the object faces the main camera
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,
            Camera.main.transform.rotation * Vector3.up);
    }
}

