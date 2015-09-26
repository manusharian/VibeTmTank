using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public Canvas exitCanvas = null;
	public Button startOnlineButton = null;
	public Button startCampaignButton = null;
	public Button optionButton = null;
	public Button exitButton = null;

	// Use this for initialization
	void Start () {

		/* Get all buttons and canvases without the main canvas */
		exitCanvas = exitCanvas.GetComponent<Canvas> ();
		startCampaignButton = startCampaignButton.GetComponent<Button> ();
		startOnlineButton = startOnlineButton.GetComponent<Button> ();
		optionButton = optionButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();

		/* do not show exit canvas */
		exitCanvas.enabled = false;

	}

	/* when exit button is pressed */
	public void ExitPress(){
		/* disable all other buttons */
		startCampaignButton.interactable = false;
		startOnlineButton.interactable = false;
		optionButton.interactable = false;
		exitButton.interactable = false;

		/* enable the new canvas for exit */
		exitCanvas.enabled = true;
	}

	/* when Play button is pressed */
	public void PlayCampaginPress(){
		Application.LoadLevel (1);
	}

	/* when Online button is pressed */
	public void PlayOnlinePress(){
		//Application.LoadLevel (2);
	}

	/* when Opions button is pressed */
	public void OptionsPlay(){
		//Application.LoadLevel (3);
		Debug.Log ("Option Pressed");
	}

	/* when Yes button is pressed */
	public void ExitYesPress(){
		Application.Quit();
	}

	/* when No button is pressed */
	public void ExitNoPress(){
		/* enalbe all other buttons */
		startCampaignButton.interactable = true;
		startOnlineButton.interactable = true;
		optionButton.interactable = true;
		exitButton.interactable = true;

		/* disable the new canvas for exit */
		exitCanvas.enabled = false;
	}
	
}
