using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startOverScreenX : MonoBehaviour
{
    public void Setup(int score)
    {
        gameObject.SetActive(true);
    }

    public void StartOverButtonX()
    {
        SceneManager.LoadScene("Challenge 1");

    }

}
