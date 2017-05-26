using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container{
	private Dictionary<int, string> showsContainer = new Dictionary<int, string>();
	private Dictionary<int, string> moviesContainer = new Dictionary<int, string>();
	private Dictionary<int, string> categoriesContainer = new Dictionary<int, string>();
	private Dictionary<int, string> nounsContainer = new Dictionary<int, string>();
	private Dictionary<int, string> booksContainer = new Dictionary<int, string>();
	private Dictionary<int, string> bffContainer = new Dictionary<int, string>();

	private Dictionary<string, string> summariesContainer = new Dictionary<string, string>();
	public Dictionary<string, string> SummariesContainer { 
		get { return summariesContainer; } 
		set { summariesContainer = value; }
	}

	private int[] timer = new int[8];

	public int[] Timer{
		get{ return timer; }
		set{ timer = value; }
	}

	public void AddToContainerUsingSwitch(string filename, KeyValuePair<int, string> valueToAdd){
		switch (filename) {
			case"BFF":
				bffContainer.Add (valueToAdd.Key, valueToAdd.Value);
				break;
			case"BOOKS":
				booksContainer.Add (valueToAdd.Key, valueToAdd.Value);
				break;
			case"MOVIES":
				moviesContainer.Add (valueToAdd.Key, valueToAdd.Value);
				break;
			case"NOUNS":
				nounsContainer.Add (valueToAdd.Key, valueToAdd.Value);
				break;
			case"SHOWS":
				showsContainer.Add (valueToAdd.Key, valueToAdd.Value);
				break;
			case"CATEGORIES":
				categoriesContainer.Add (valueToAdd.Key, valueToAdd.Value);
				break;
		}
	}

	public Dictionary<int,string> GetContainerUsingSwitch(string filename){
		switch (filename) {
			case"BFF":
				return bffContainer;
			case"BOOKS":
				return booksContainer;
			case"MOVIES":
				return moviesContainer;
			case"NOUNS":
				return nounsContainer;
			case"SHOWS":
				return showsContainer;
			case"CATEGORIES":
				return categoriesContainer;
			default:
				return null;
		}
	}



}

