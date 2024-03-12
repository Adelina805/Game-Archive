using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    public float height = 0;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }
}
