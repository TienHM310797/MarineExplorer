using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIManager : MonoSingleton<UIManager>
{
	public void EnablePopaUasdqpCoin(){
		qwecv.SetActive(false);
		poasdqpUp.SetActive(true);
	}

	public void DisablePasddqwopUpCoin(){
		qwecv.SetActive(true);
		poasdqpUp.SetActive(false);
	}

	public void OpenasdqopqUpDiamond(){
		qwecv.SetActive(false);
		xcve.SetActive(true);
	}

	public void ClosasvdqeShopDiamond ()
	{
		qwecv.SetActive (true);
		xcve.SetActive (false);
	}
	[FormerlySerializedAs("_lb")] public Text _asdqlb;
	[FormerlySerializedAs("thuong")] public GameObject asdqwe;
	[FormerlySerializedAs("popUp")] public GameObject poasdqpUp;
	[FormerlySerializedAs("popUpDiamond")] public GameObject xcve;
	[FormerlySerializedAs("UiRoot")] public GameObject qwecv;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void EndBasdquySucssess ()
	{
		PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt ("gold", 450) + 200);
		asdqwe.SetActive (true);
		_asdqlb.text = "" + PlayerPrefs.GetInt ("gold", 450);
		if (poasdqpUp.activeInHierarchy == true) {
			qwecv.SetActive(true);
			poasdqpUp.SetActive (false);
		}
	}

	public void EnablePopUasdqpCoin(){
		qwecv.SetActive(false);
		poasdqpUp.SetActive(true);
	}

	public void DisablePasdqwopUpCoin(){
		qwecv.SetActive(true);
		poasdqpUp.SetActive(false);
	}

	public void OpenasdqopUpDiamond(){
		qwecv.SetActive(false);
		xcve.SetActive(true);
	}

	public void ClosasdqeShopDiamond ()
	{
		qwecv.SetActive (true);
		xcve.SetActive (false);
	}
}
