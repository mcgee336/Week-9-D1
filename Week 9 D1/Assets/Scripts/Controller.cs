using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{

    [SerializeField] InputAction movement;

     void OnEnable()
    {
        movement.Enable();
    }
     void OnDisable()
    {
        movement.Disable();
    }

    void Update()
    {
        float xThrow = movement.ReadValue<Vector2>().x;
        float yThrow = movement.ReadValue<Vector2>().y;

        float xOffset = 0.1f;
        float newXPos = transform.position.x + xOffset;

        transform.localPosition = new Vector3 
            (xOffset, 
            transform.localPosition.y, 
            transform.localPosition.z);
    }
}
