using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("Play() - SceneManager.LoadScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Debug.Log("Game ended - Application.Quit");
        Application.Quit();
    }
}
