using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300f;
     [SerializeField] float moveSpeed = 20f; 
    private void Start() 
    {
        
    }

    private void Update() 
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0 ,0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
