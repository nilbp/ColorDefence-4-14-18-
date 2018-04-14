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
	public void tutorial(string Nil_Level){

		SceneManager.LoadScene (Nil_Level);
		FindObjectOfType<AudioManager>().Stop("Tema1");
		FindObjectOfType<AudioManager>().Play("Tema2");
	}
	public void lvl1(string Nil_Level1){

		SceneManager.LoadScene (Nil_Level1);
		FindObjectOfType<AudioManager>().Stop("Tema1");
		FindObjectOfType<AudioManager>().Play("Tema2");
	}
	public void lvl2(string Nil_Level2){

		SceneManager.LoadScene (Nil_Level2);
		FindObjectOfType<AudioManager>().Stop("Tema1");
		FindObjectOfType<AudioManager>().Play("Tema2");
	}
	public void mainMenu(string MainMenu){

		SceneManager.LoadScene (MainMenu);
		FindObjectOfType<AudioManager>().Stop("Tema2");
		FindObjectOfType<AudioManager>().Play("Tema1");
	}
}
