using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameOverCanvas;
    
    void Start()
    {
        Time.timeScale = 1;
        GameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restablecer()
    {
        SceneManager.LoadScene(0);
    }
}
