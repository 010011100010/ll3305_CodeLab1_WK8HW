using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStructure : MonoBehaviour {
	public List<string> names; //list is slower than array, but more flexable
	public Queue<string> waitInLine = new Queue<string>(); //Queue is a "First In First Out" data structure: the data being put in first will be extracted first
	public Stack<string> stack = new Stack<string>(); //Stack is a "Last In First Out" data structure
	public Dictionary<string,string> websters = new Dictionary<string,string>(); //assciociate non-numeric keys to values


	// Use this for initialization
	void Start () {
		//List
		names.Add ("poop");

		//string[] nameArray = names.ToArray; //convert the content in this list to array

		for (int i = 0; i < names.Count; i++) {
			Debug.Log (names [i]);
		}

		//Queue
		waitInLine.Enqueue ("red door"); //Enqueue put values in a queue
		waitInLine.Enqueue ("blue");
		waitInLine.Enqueue ("green");

		string firstInLine = waitInLine.Dequeue (); //Dequeue extract values from a queue
		Debug.Log (firstInLine);

		Debug.Log (waitInLine.Peek());
		
		//Stack



		//Dictionary
		websters.Add("car", "4 wheel automobile");
		websters.Add ("camel", "horse by commitee");
		websters.Add ("toliet", "clogged by Mr.Leak");

		Debug.Log (websters["car"]);

		foreach (string key in websters.Keys) {
			Debug.Log ("Key: " + key + " value: " + websters [key]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
