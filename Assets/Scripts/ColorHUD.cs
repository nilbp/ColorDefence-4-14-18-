using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorHUD : MonoBehaviour {

    public GameObject cyanButton;
    public GameObject magentaButton;
    public GameObject yellowButton;

    public static ColorHUD instance;

    private void Start()
    {
        instance = this;
    }

    public void NoColor()
    {
        MouseManager.ColorInHand = ' ';
    }

	public void CyanButton()
	{
        FindObjectOfType<AudioManager>().Play("Select");
        MouseManager.ColorInHand = 'C';
        cyanButton.SetActive(true);
        magentaButton.SetActive(false);
        yellowButton.SetActive(false);
    }
	public void MagentaButton()
	{
        FindObjectOfType<AudioManager>().Play("Select");
        MouseManager.ColorInHand = 'M';
        cyanButton.SetActive(false);
        magentaButton.SetActive(true);
        yellowButton.SetActive(false);
    }
	public void YellowButton()
	{
        FindObjectOfType<AudioManager>().Play("Select");
        MouseManager.ColorInHand = 'Y';
        cyanButton.SetActive(false);
        magentaButton.SetActive(false);
        yellowButton.SetActive(true);
    }


}
