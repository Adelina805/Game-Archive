using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastPress;
    private float startDelay = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PressedSpace();
        }
    }

    void PressedSpace()
    {
        // Check if enough time has passed
        if (lastPress + startDelay > Time.unscaledTime)
        {
            return;
        }
        lastPress = Time.unscaledTime;

        // spawn dog
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
