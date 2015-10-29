//衝突を検知したらゲームオーバー
using UnityEngine;
using System.Collections;

public class BottomScript : MonoBehaviour {

	public GameObject dunce;	//ゲームオーバーもじ
	public GameObject bar;
	bool goTitle = false;	//ゲームオーバー判定子


	void Update () {
		if(goTitle){
			if(Input.GetMouseButtonDown(0)){
				Application.LoadLevel ("Title");
			}
		}
	}
	

	void OnCollisionEnter(Collision col) {
		Destroy (col.gameObject);//ぶつかってきたオブジェクトが消える ボール消滅 
		//Destroy (gameObject); これはアタッチされたオブジェクト(自分)が消える
		Destroy (bar);
		dunce.SendMessage ("Lose");
		goTitle = true;
	}
}
