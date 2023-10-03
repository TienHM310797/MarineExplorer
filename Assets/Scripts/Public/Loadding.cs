using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Loadding : MonoBehaviour {

	void Ssdftart () {
		loaddasdweingBar.fillAmount=0;
	}
	
	// Update is called once per frame
	void Updaddte () {
	
		if(loaddasdweingBar.fillAmount<=1){
			loaddasdweingBar.fillAmount+=1.0f/loaddinasdqweTime*Time.deltaTime;

		}
		if(loaddasdweingBar.fillAmount==1){
			insdfwedex++;
			Application.LoadLevel(NameLasdqweoadLevel);
//			MyAdsManager.Instance.ShowInterStitial();
		}
	}
	// Use this for initialization
	[FormerlySerializedAs("loaddingTime")] public float loaddinasdqweTime;
	[FormerlySerializedAs("loaddingBar")] public Image loaddasdweingBar;
	[FormerlySerializedAs("NameLoadLevel")] public string NameLasdqweoadLevel;
	public static int insdfwedex;
	void Start () {
		loaddasdweingBar.fillAmount=0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(loaddasdweingBar.fillAmount<=1){
			loaddasdweingBar.fillAmount+=1.0f/loaddinasdqweTime*Time.deltaTime;

		}
		if(loaddasdweingBar.fillAmount==1){
			insdfwedex++;
			Application.LoadLevel(NameLasdqweoadLevel);
//			MyAdsManager.Instance.ShowInterStitial();
		}
	}
}
