using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameModel{

	private Dictionary<int, string> wordsInPlayContainer = new Dictionary<int, string>();

	private string title, summary;

	private int timer, playerOneScore, playerTwoScore;

	public string Title {
		get{ return title ; }
	}

	public string Summary {
		get{ return summary ; }
	}

	public int Timer {
		get { return timer; }
	}

	public int PlayerOneScore {
		get{ return playerOneScore; }
		set{ playerOneScore = value; }
	}

	public int PlayerTwoScore {
		get{ return playerTwoScore; }
		set{ playerTwoScore = value; }
	}

	public Dictionary<int, string> WordsInPlayContainer{
		get {return wordsInPlayContainer; }
	}


	public void initialiseGame(string gameName){
		XMLtoContainer.Instance.container.SummariesContainer.TryGetValue (gameName, out this.summary);
		switch (gameName) {
		case "5SecondSummaries":
			wordsInPlayContainer = XMLtoContainer.Instance.container.GetContainerUsingSwitch ("MOVIES");
			title = "5 Second Summaries";
			timer = XMLtoContainer.Instance.container.Timer [0];
			break;
		case "BFF":
			wordsInPlayContainer = XMLtoContainer.Instance.container.GetContainerUsingSwitch ("BFF");
			title = "Best Friends Challenge";
			timer = XMLtoContainer.Instance.container.Timer [1];
			break;
		case "Jinx":
			wordsInPlayContainer = XMLtoContainer.Instance.container.GetContainerUsingSwitch ("CATEGORIES");
			title = "Jinx Challenge";
			timer = XMLtoContainer.Instance.container.Timer [2];
			break;
		case "SayAnything":
			wordsInPlayContainer = null;
			title = "Say Anything";
			timer = XMLtoContainer.Instance.container.Timer [3];
			break;
		case "Whisper":
			wordsInPlayContainer = XMLtoContainer.Instance.container.GetContainerUsingSwitch ("NOUNS");
			title = "Whisper Challenge";
			timer = XMLtoContainer.Instance.container.Timer [4];
			break;
		case "Password":
			wordsInPlayContainer = XMLtoContainer.Instance.container.GetContainerUsingSwitch ("NOUNS");
			title = "Password";
			timer = XMLtoContainer.Instance.container.Timer [5];
			break;
		case "Charades":
			wordsInPlayContainer = XMLtoContainer.Instance.container.GetContainerUsingSwitch ("NOUNS");
			title = "Charades";
			timer = XMLtoContainer.Instance.container.Timer [6];
			break;
		case "Catchphrase":
			wordsInPlayContainer = XMLtoContainer.Instance.container.GetContainerUsingSwitch ("NOUNS");
			title = "Charades";
			timer = XMLtoContainer.Instance.container.Timer [7];
			break;
		}

	}




}
