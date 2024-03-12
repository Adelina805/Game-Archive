using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectorFB : MonoBehaviour
{
    private int items = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("redDiamond"))
        {
            Destroy(collision.gameObject);
            items++;
            Debug.Log("Red diamonds: " + items);
        }
    }
}
