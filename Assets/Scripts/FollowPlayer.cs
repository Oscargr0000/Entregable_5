using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(0, 10, 0);

    private void Uptade()
    {
        transform.position = Player.transform.position + offset;
    }
}
    

