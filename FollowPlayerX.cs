using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(40, 0, 7);

    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
