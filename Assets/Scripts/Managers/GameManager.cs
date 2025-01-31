using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        ResetGame();
        QuitGame();
    }

    void QuitGame()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void ResetGame()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
