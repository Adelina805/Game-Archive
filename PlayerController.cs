using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public startOverScreen startOverScreen;
    int var = 0;

    private float speed = 30.0f;
    private float turnSpeed = 150.0f;
    private float horizontalInput;
    private float verticalInput;
    public bool vehicleAlive = true;

    public void GameOver()
    {
        startOverScreen.Setup(var);
    }
    
    void Update()
    {
        // Receive player input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle forward or back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Turn the vehicle left or right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Kill car if goes off track
        if (transform.position.y < -30)
        {
            GameOver();
            vehicleAlive = false;
        }
    }
}
