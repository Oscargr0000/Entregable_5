using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;

    public float speed = 10f;
    public float turnSpeed = 20f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //Static movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        /*if (Input.GetKeyDown(KeyCode.W))
        {
            verticalInput = Input.GetAxis("Vertical");
            transform.Rotate(Vector3Quaternion * turnSpeed * Time.deltaTime);
        }*/
    }
}
