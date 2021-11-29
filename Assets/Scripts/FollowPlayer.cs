using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(10, 0, 0);

    private void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}
    

