using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool fishIsAlive = true;
    public AudioSource src;
    public AudioClip pop;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && fishIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            src.PlayOneShot(pop);
        }
        if (transform.position.y > 17 || transform.position.y < -17)
        {
            logic.gameOver();
            fishIsAlive = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        fishIsAlive = false;
    }
}
