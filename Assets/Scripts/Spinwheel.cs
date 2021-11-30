using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinwheel : MonoBehaviour
{

    private float turnSpeed = 400f;

    // Update is called once per frame
    void Update()
    {
        //Rotation of the propeller
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
    }
}
