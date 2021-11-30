using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(40, 0, 0);

    private void Update()
    {
        //Camara following the plane + Distance from the plane
        transform.position = Player.transform.position + offset;
    }
}
    

