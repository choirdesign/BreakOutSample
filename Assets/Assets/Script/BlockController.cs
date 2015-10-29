//衝突を検知したら消える

using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		Destroy (gameObject);
	}
}
