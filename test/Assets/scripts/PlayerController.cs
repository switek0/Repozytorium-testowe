using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int liczbacalkowita; // np. 1,2,54,76
    float liczbaprzecinkowa = 0.1f; // np. 4.32423, 56.23423

    public float speed = 5;

    public Rigidbody rigidbody;
    
    public Transform Startpoint;
   
    public int zebranepunkty;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();


        }

    void Update()
    {
        if (Input.GetAxis("Horizontal") !=0)
        {
            float directionHorizontal = Input.GetAxis("Horizontal");
            rigidbody.AddForce(directionHorizontal * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);

        }

        if (Input.GetAxis("Vertical") != 0)
        {
            float directionVertical = Input.GetAxis("Vertical");
            rigidbody.AddForce(0, 0, directionVertical * Time.deltaTime * speed, ForceMode.Impulse);

        }
            if(transform.position.y < 0)
        {
            transform.position = Startpoint.position;
            rigidbody.velocity = Vector3.zero;
        }
    
    
    }


}
