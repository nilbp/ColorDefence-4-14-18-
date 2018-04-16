using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


	public void ExitBtn(){

		Application.Quit();

	}
	public void OptionsBtn(string options){

		SceneManager.LoadScene (options);

	}
	public void lvlSelectBtn(string lvlSelector){

		SceneManager.LoadScene (lvlSelector);

	}
	public void tutorial(string tutorial){

		SceneManager.LoadScene (tutorial);
		FindObjectOfType<AudioManager>().Stop("Tema1");
		FindObjectOfType<AudioManager>().Play("Tema2");
	}
	public void lvl1(string lvl1){

		SceneManager.LoadScene (lvl1);
		FindObjectOfType<AudioManager>().Stop("Tema1");
		FindObjectOfType<AudioManager>().Play("Tema2");
	}
	public void lvl2(string lvl2){

		SceneManager.LoadScene (lvl2);
		FindObjectOfType<AudioManager>().Stop("Tema1");
		FindObjectOfType<AudioManager>().Play("Tema2");
	}
    public void lvl3(string lvl3)
    {

        SceneManager.LoadScene(lvl3);
        FindObjectOfType<AudioManager>().Stop("Tema1");
        FindObjectOfType<AudioManager>().Play("Tema2");
    }

    public void lvl4(string lvl4)
    {

        SceneManager.LoadScene(lvl4);
        FindObjectOfType<AudioManager>().Stop("Tema1");
        FindObjectOfType<AudioManager>().Play("Tema2");
    }

    public void lvl5(string lvl5)
    {

        SceneManager.LoadScene(lvl5);
        FindObjectOfType<AudioManager>().Stop("Tema1");
        FindObjectOfType<AudioManager>().Play("Tema2");
    }

    public void lvl6(string lvl6)
    {

        SceneManager.LoadScene(lvl6);
        FindObjectOfType<AudioManager>().Stop("Tema1");
        FindObjectOfType<AudioManager>().Play("Tema2");
    }

    public void mainMenu(string MainMenu){

		SceneManager.LoadScene (MainMenu);
		FindObjectOfType<AudioManager>().Stop("Tema2");
		FindObjectOfType<AudioManager>().Play("Tema1");
	}

    //Funció d desbloquejar nivells
    public void EndLevel(int level)
    {
        int currentLevelProgress = PlayerPrefs.GetInt("levelReached");

        if (level < currentLevelProgress) { return; }

        else { PlayerPrefs.SetInt("levelReached", level); }
    }
}
