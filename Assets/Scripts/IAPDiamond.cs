using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class IAPDiamond : MonoBehaviour {
	void Staasdrt () {
		
	}
	
	// Update is called once per frame
	void Updawte () {
		
	}

	public void SetDqiamond(int numDiamond){
		PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + numDiamond);
		asdqwe.text = PlayerPrefs.GetInt("diamond") + "";
	}

	[FormerlySerializedAs("TextDiamond")] public Text asdqwe;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetDiamond(int numDiamond){
		PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + numDiamond);
		asdqwe.text = PlayerPrefs.GetInt("diamond") + "";
	}
}
