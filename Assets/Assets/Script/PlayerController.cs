//Barを左右に動かす
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Vector3 mousePos;
	private Vector3 worldPointPos;
	public float limitPosLeft;
	public float limitPosRight;
	public float barHeight;

	// Update is called once per frame
	void Update () {
		//マウス位置座標をVector3で取得
		mousePos = Input.mousePosition;
		//マウス位置座標をスクリーン座標からワールド座標に変換する
		worldPointPos = Camera.main.ScreenToWorldPoint (mousePos);

		//壁を突き抜けないようにx軸の移動範囲を制限
		if (worldPointPos.x <= limitPosLeft) {
			worldPointPos.x = limitPosLeft;
		} else if (worldPointPos.x >= limitPosRight) {
			worldPointPos.x = limitPosRight;
		}

		//y軸とz軸を固定
		worldPointPos.y = barHeight;
		worldPointPos.z = 0.0f;

		//ワールド座標をバーの位置に変換
		gameObject.transform.position = worldPointPos;
	
	}
}
