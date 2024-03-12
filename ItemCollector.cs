using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int items = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("blueDiamond"))
        {
            Destroy(collision.gameObject);
            items++;
            Debug.Log("Blue diamonds: " + items);
        }
    }
}
