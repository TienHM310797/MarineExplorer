using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;


public class shopScenes : MonoBehaviour
{
	void Updasdate ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel ("Home");
		}
	}


	public void HomeasdqBuqqtoon ()
	{
		Application.LoadLevel ("Home");
	}



	public void canasdeqdcleAds ()
	{
		adsasdq.SetActive (false);
	}

	[FormerlySerializedAs("thuong")] public GameObject thuasdqong;
	[FormerlySerializedAs("ads")] public GameObject adsasdq;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel ("Home");
		}
	}


	public void HomeasdqButoon ()
	{
		Application.LoadLevel ("Home");
	}



	public void canasdqdcleAds ()
	{
		adsasdq.SetActive (false);
	}
}
