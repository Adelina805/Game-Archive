using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed = 300f;

    void LateUpdate()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
