using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed, rotationSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
    }
}
