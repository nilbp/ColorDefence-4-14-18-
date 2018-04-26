using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class monSelector : MonoBehaviour {

	//public int level;
	public Button[] levelButtons;
    int levelReached;


    void Start () 
	{
        PlayerPrefs.SetInt("levelReached",30);

        levelReached = PlayerPrefs.GetInt ("levelReached");

        for (int i = 0; i < levelButtons.Length; i++) {
			if (i > levelReached)//levelReached)
				levelButtons [i].interactable = false;
		}

      
    }
	
	// Update is called once per frame
	void Update () 
	{
        Debug.Log(levelReached);
    }

}

  
