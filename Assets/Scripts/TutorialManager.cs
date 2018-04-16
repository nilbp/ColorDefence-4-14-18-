using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour {

    public static bool gameOver;
    public GameObject gameoverPanel;

    public GameObject endPanel;

    public int numWaves;

    public static bool lastMinion;
    public GameObject[] panel;
    public int index = 0;

    public static TutorialManager tutorialManager;

    void Start()
    {
        tutorialManager = this;

        //Time.timeScale = 0;
        //Invoke("CheckLastMinion", 1);
    }

    private void Update()
    {
        CheckLastMinion();
    }

    void CheckLastMinion()
    {
        if (lastMinion)
        {
            if (numWaves == 0) { endPanel.SetActive(true); return;  }
            LoadNext();
            lastMinion = false;
            numWaves--;

            
        }
        
        GameOver();
    }

    public void LoadNext()
    {
        Time.timeScale = 0;
        panel[index].SetActive(false);
        panel[index+1].SetActive(true);
        index ++;
    }
    public void LoadLast()
    {
        panel[index].SetActive(false);
        Time.timeScale = 1;

    }

    public void LoadFirst(int i)
    {
        panel[index].SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    void GameOver()
    {
        if (gameOver)
        {
            gameoverPanel.SetActive(true);

            Invoke("ChangeLevel", 4.5f);
        }
    }

    void ChangeLevel()
    {
		gameoverPanel.SetActive (false);
        SceneManager.LoadScene("lvlSelector");
		gameOver = false;
    }
}
