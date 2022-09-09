using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAbout : MonoBehaviour
{

    [SerializeField]
    [Range(0.1f, 20f)]
    private float moveSpeed, radius;

    [SerializeField] [Range(-1, 300)] private int targetFrameRate = -1;
        
    
    [SerializeField] private bool isUsingDeltaTime = true;
    
    
    private float _angle;

    private const float SlowFactor = 0.005f;
 
    void Start()
    {
        // Make the game run as fast as possible
        Application.targetFrameRate = targetFrameRate;
    }
    
    //Try changing this to fixed update
    void FixedUpdate()
    {

        if (isUsingDeltaTime)
        {
            _angle += moveSpeed * Time.deltaTime;
        }
        else
        {
            _angle += moveSpeed * SlowFactor;
        }
        
        transform.position = new Vector3(Mathf.Cos(_angle),  0, Mathf.Sin(_angle)) * radius;
    }
}
