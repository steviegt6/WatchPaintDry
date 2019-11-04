using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TheGame : MonoBehaviour
{
    public void ReturnToMenu()
    {
        Debug.Log("Play() - SceneManager.LoadScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
