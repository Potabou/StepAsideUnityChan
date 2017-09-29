using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallController : MonoBehaviour {
	
	//unityちゃんのオブジェクト
	private GameObject unitychan;
	//unityちゃんとカメラの距離
	private float difference;

	// Use this for initialization
	void Start () {

		//unityちゃんのオブジェクト取得
		this.unitychan = GameObject.Find("unitychan");
		//unityちゃんとカメラの位置の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {

		//unityちゃんの位置に合わせてカメラを移動
		this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);

	}

	void OnTriggerEnter(Collider other){

		if(other.CompareTag("CoinTag")){
			Destroy(other.gameObject);
			Debug.Log("コインを破棄しました");
		}else if (other.CompareTag("CarTag")){
			Destroy(other.gameObject);
			Debug.Log("車を破棄しました");
		}else if (other.CompareTag("TrafficConeTag")){
			Destroy(other.gameObject);
			Debug.Log("コーンを破棄しました");
		}
	}
}
