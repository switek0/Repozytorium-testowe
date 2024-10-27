using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    public Transform playerTransform;
    public Vector3 cameraOffset;

    void Start()
    {

        
    }

    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;




    }
}
