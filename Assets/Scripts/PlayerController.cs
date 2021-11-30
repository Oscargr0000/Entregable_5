using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;

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
        verticalInput = Input.GetAxis("Vertical");

        //Static movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Rotation with W and S
        transform.Rotate(Vector3.left * turnSpeed * Time.deltaTime * verticalInput);
    }
}
