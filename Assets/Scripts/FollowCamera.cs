using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingTofollow;

    private void Update() 
    {
        transform.position = thingTofollow.transform.position + new Vector3(0, 0, -10);
    }
}
