using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class GameController : MonoBehaviour{

	private GameModel gameModel;
	private System.Random randomNumberGenerator;

	[Header("Summary Canvas")]
	public GameObject twoPlayerRules;
	public GameObject twoPlayerHeaderText;
	public GameObject fourPlayerRules;
	public GameObject fourPlayerHeaderText;
	[Header("Game Canvas")]
	public GameObject twoPlayerStartButton;
	public GameObject fourPlayerStartButton;
	[Header("Main Camera")]
	public GameObject mainCamera;

	public GameController(){
		gameModel = new GameModel ();
		randomNumberGenerator = new System.Random ();
	}

	public void SetupGame(string gameName){
		gameModel.initialiseGame (gameName);
		UpdateSummaryUI ();
	}

	public void UpdateSummaryUI(){
		twoPlayerRules.GetComponent<Text> ().text = gameModel.Summary;
		twoPlayerHeaderText.GetComponent<Text> ().text = gameModel.Title;
		fourPlayerRules.GetComponent<Text> ().text = gameModel.Summary; //Just doing both because of time saved over performance
		fourPlayerHeaderText.GetComponent<Text> ().text = gameModel.Title;

	}

	public void StartGameButton(){
		

	}

	private int getAppropriateRandomNumber(){
		return Convert.ToInt32(randomNumberGenerator.Next(gameModel.WordsInPlayContainer.Count));
	}

}

