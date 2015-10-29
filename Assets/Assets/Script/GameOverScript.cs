//まぬけ文字を表示する
using UnityEngine.UI;
using UnityEngine;
using System.Collections;


public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text> ().enabled = false;
	}
	
	// Update is called once per frame
	void Lose () {
		gameObject.GetComponent<Text> ().enabled = true;
	}
}
