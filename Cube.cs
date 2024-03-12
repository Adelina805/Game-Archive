using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float xAngle = 10.0f;
    public float yAngle = 0.0f;
    public float zAngle = 0.0f;
    public float delay = 3;
    private float interval = 1.5f;

    void Start()
    {
        // randomize
        InvokeRepeating("Randomize", delay, interval);
    }

    void Update()
    {
        // rotate
        transform.Rotate(xAngle * Time.deltaTime, yAngle, zAngle);
    }

    void Randomize()
    {
        // generate color
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0F, 1F), Random.Range(0F, 1F), Random.Range(0F, 1F), Random.Range(0F, 1f));

        // generate location
        transform.position = new Vector3(Random.Range(-25,25), Random.Range(0,20), Random.Range(-25, 25));

        // generate scale
        transform.localScale = Vector3.one * Random.Range(1, 5);

        // generate rotation angles
        xAngle = Random.Range(0F, 360F);
        yAngle = Random.Range(0F, 360F);
        zAngle = Random.Range(0F, 360F);
    }
}
