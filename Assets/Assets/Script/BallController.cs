//1最初にボールが飛んでいく
//2ボールカウントがゼロになったらゲームクリア
using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	//1 飛ばす速さ、力の加え先RigidBody
	int speed = 5;
	Rigidbody rb;

	//2
	public GameObject done;
	public int blockCt = 20;

	//1Use this for initialization
	void Start () {
		//キャッシュ処理
		rb = GetComponent<Rigidbody> ();
		//右上にspeedの力ぶんだけボールを飛ばす
		//ブロック崩しの決まり文句ForceMode.VelocityChange = 質量無視でrigidBodyに瞬時に速度変化を追加する
		rb.AddForce ((transform.up + transform.right) * speed, ForceMode.VelocityChange);
	}
	
	//2Update is called once per frame
	void Update () {
		//2ブロックを全部こわしたら文字を表示
		if (blockCt == 0) {
			//2ボールの動きを止める
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			//2文字をだす
			done.SendMessage ("Win");
			if (Input.GetMouseButtonDown (0)) {
				Application.LoadLevel ("Title");
			}
		}
	}

	//2ブロックにぶつかるとカウントがへる
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Block"){
			blockCt -= 1;
			Debug.Log (blockCt);
		}
	}
}
