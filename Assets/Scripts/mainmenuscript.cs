using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{
    public void PlayTheGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    
    public void QuitTheGame()
    {
        Debug.Log("Quitting the game.");
        Application.Quit();
    }
}
