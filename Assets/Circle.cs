using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Circle : MonoBehaviour
{

    [SerializeField] private InputAction pressed, axis;
    [SerializeField] private float speed = 1f;

    private Vector2 rotation;
    private bool rotateAllowed;
    // Start is called before the first frame update
    void Awake()
    {
        pressed.Enable();
        axis.Enable();
        pressed.performed += _ => { StartCoroutine(Rotate()); };
        pressed.canceled += _ => { rotateAllowed = false; };
        axis.performed += context => { rotation = context.ReadValue<Vector2>(); };
    }

    IEnumerator Rotate()
    {
        rotateAllowed = true;
        while (rotateAllowed)
        {
            rotation *= speed;
            transform.Rotate(Vector3.back, rotation.x);
            yield return null;
        }
    } 
}
