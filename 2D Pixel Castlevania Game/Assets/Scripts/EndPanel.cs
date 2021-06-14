using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPanel : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("RestartButton"))
        {
            SceneManager.LoadScene("Graveyard Slash-Final");
        }
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Graveyard Slash-Final");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Graveyard Slash-Final");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
