using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class XMLtoContainer : Singleton<XMLtoContainer>{

	// Use this for initialization
	void Start (){
		InitialiseContainers ();
	}
	
	public Container container = new Container ();
	private XmlTextReader xmlReader;
	private string[] containerNames = {"BFF", "BOOKS", "MOVIES", "NOUNS", "SHOWS", "SUMMARIES"};


	void InitialiseContainers(){
		foreach (string filename in containerNames) {
			TryLocatingXMLFile ("Assets/XML/" + filename + ".xml");
			if (filename == "SUMMARIES")
				LoadSummariesFromXML ();
			else
				LoadWordListFromXML (filename);
		}
	}

	private void TryLocatingXMLFile(string XMLFilename){
		try{
			xmlReader = new XmlTextReader (XMLFilename);
		}catch(Exception e){
			Debug.Log ("Error: " + e);
		}

	}

	private void LoadWordListFromXML(string filename){
		int counter = 0;
		while (xmlReader.ReadToFollowing("Data")){
			KeyValuePair<int, string> temp = new KeyValuePair<int, string>(counter++, xmlReader.ReadString());
			container.AddToContainerUsingSwitch(filename, temp);
		}	
	}

	private void LoadSummariesFromXML(){
		int counter = 0;
		int[] timer = new int[8];
		while (xmlReader.ReadToFollowing("Data")){
			string title = xmlReader.ReadString ();
			xmlReader.ReadToFollowing ("Data");
			string summary = xmlReader.ReadString ();
			xmlReader.ReadToFollowing ("Data");
			timer [counter++] = Convert.ToInt32 (xmlReader.ReadString ());
			container.SummariesContainer.Add(title, summary);
		}	
		container.Timer = timer;

	}

	//For formating and debugging
	private void WriteXML(string filename){
		XmlWriter xmlWriter = XmlWriter.Create("Assets/XML/" + filename + "_new.xml");

		xmlWriter.WriteStartDocument();
		xmlWriter.WriteStartElement(filename);

		foreach (KeyValuePair<int, string> pair in container.GetContainerUsingSwitch(filename)) {
			xmlWriter.WriteStartElement ("Data");
			xmlWriter.WriteString (pair.Value.ToString());
			xmlWriter.WriteEndElement ();
		}

		xmlWriter.WriteEndDocument();
		xmlWriter.Close();

	}

	//For formating and debugging
	private void PrintDictionary(){
		foreach (KeyValuePair<string, string> pair in container.SummariesContainer) {
			Debug.Log (pair.Key + " : " + pair.Value);
		}
	}

}

