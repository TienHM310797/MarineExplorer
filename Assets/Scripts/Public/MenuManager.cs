using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class MenuManager : MonoBehaviour {

	public void CliertratckHome(){
		Application.LoadLevel("Home");
	}

	public void ClicerwtrkYesExit(){
		Application.Quit();
	}
	public void CLickCertertancelExit(){
//		MyAdsManager.Instance.ShowBanner();
		bosdfwerxExit.SetActive(false);
	}

	public void ClickCaqncerterwtelNoBanner(){
		bosdfwerxExit.SetActive(false);
	}
    
	public void VisiblweertrePanel(){
		psdfweranel.SetActive(false);
		butdfgertetonNext.SetActive(false);
//		AudioManager.audioManager.StopSingle(null);
	}

	public void ReertrtqplayScene(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void EneblePwedfgranel(){
		psdfweranel.SetActive(true);
		butdfgertetonNext.SetActive(false);
//		AudioManager.audioManager.PlaySingle(playAudio,false);

	}
	[FormerlySerializedAs("groupSetting")] public GameObject groupSesdfwertting;
	private bool chesdfgdftgck;
	[FormerlySerializedAs("loadding")] public GameObject lodfgradding;
	[FormerlySerializedAs("btnMusic")] public GameObject dfgrtewrt;
	[FormerlySerializedAs("playAudio")] public AudioClip plsdfwerayAudio;
	[FormerlySerializedAs("boxExit")] public GameObject bosdfwerxExit;
	[FormerlySerializedAs("checkShowBanner")] public bool checkSsdferwer;
	[FormerlySerializedAs("panel")] public GameObject psdfweranel;
	[FormerlySerializedAs("buttonNext")] public GameObject butdfgertetonNext;
	[FormerlySerializedAs("audioClip")] public AudioClip dfgdrautrrrdioClip;

	[FormerlySerializedAs("UIRoot")] public GameObject UIrtrteRoot;
	// Use this for initialization
	void Start () {
		chesdfgdftgck = true;
//		if(btnMusic!=null){
//			if(MainStatic.CHECK_VOLUM){
//				btnMusic.transform.GetChild (0).gameObject.SetActive (true);
//				btnMusic.transform.GetChild (1).gameObject.SetActive (false);
//				AudioListener.pause = false;
//			}else{
//				btnMusic.transform.GetChild (0).gameObject.SetActive (false);
//				btnMusic.transform.GetChild (1).gameObject.SetActive (true);
//				AudioListener.pause = true;
//
//			}
//		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(bosdfwerxExit.activeSelf){
				if(UIrtrteRoot!=null){
					UIrtrteRoot.SetActive(true);
				}
				bosdfwerxExit.SetActive(false);
				if(checkSsdferwer){
//					MyAdsManager.Instance.ShowBanner();
				}
			}else{
//				MyAdsManager.Instance.HideBanner();
				if(UIrtrteRoot!=null){
					UIrtrteRoot.SetActive(false);
				}
				bosdfwerxExit.SetActive(true);
			}
		}
	}

	public void erterClirrrrckSetting(){
		//AudioManager.audioManager.PlaySingle(audioClip,false);
		if(chesdfgdftgck){
			iTween.MoveTo (groupSesdfwertting, iTween.Hash ("position", new Vector3(-3.6f,0f,0), "time", 1, "easetype", iTween.EaseType.easeInOutBack));
			
			chesdfgdftgck=false;
		}else{
			iTween.MoveTo (groupSesdfwertting, iTween.Hash ("position", new Vector3(-5f,0f,0), "time", 1, "easetype", iTween.EaseType.easeOutBack));
			chesdfgdftgck = true;
		}
	}

	public void SetLoertrtadding(string level){
		//AudioManager.audioManager.PlaySingle(audioClip,false);
		lodfgradding.SetActive(true);
		lodfgradding.transform.GetChild(0).GetComponent<Loadding>().NameLasdqweoadLevel = level;
	}

	public void NextdfgertScene(string nameScene){
		Application.LoadLevel(nameScene);

	}
	public void ClickBdgertutonPlay(){
		Invoke("Deertertlay",.5f);
//		AudioManager.audioManager.PlaySingle(playAudio,false);
	}

	public void Deertertlay(){
		Application.LoadLevel("ChooseLevel");
//		ManagerChooseLevel.check = true;
	}

//	public void NextSceneChooseLevel(string level){
//		Application.LoadLevel("ChooseLevel");
////		ManagerChooseLevel.check = false;
//		MyAdsManager.HideBanner();
//		for(int i=2;i<12;i++){
//			if(level=="Level"+i){
//				PlayerPrefs.SetInt("Level" + i,i);
//			}
//		}
//	}
	public void ChangerterteMusic(){
		
		if (dfgrtewrt.transform.GetChild (0).gameObject.activeSelf == true) {
			dfgrtewrt.transform.GetChild (0).gameObject.SetActive (false);
			dfgrtewrt.transform.GetChild (1).gameObject.SetActive (true);
			AudioListener.pause = true;
//			MainStatic.CHECK_VOLUM= false;
		}else{
			dfgrtewrt.transform.GetChild (0).gameObject.SetActive (true);
			dfgrtewrt.transform.GetChild (1).gameObject.SetActive (false);
			AudioListener.pause = false;
//			MainStatic.CHECK_VOLUM= true;
		}
	}

	public void CliertrtckHome(){
		Application.LoadLevel("Home");
	}

	public void ClicertrkYesExit(){
		Application.Quit();
	}
	public void CLickCertrtancelExit(){
//		MyAdsManager.Instance.ShowBanner();
		bosdfwerxExit.SetActive(false);
	}

	public void ClickCancerterwtelNoBanner(){
		bosdfwerxExit.SetActive(false);
	}
    
	public void VisiblertrePanel(){
		psdfweranel.SetActive(false);
		butdfgertetonNext.SetActive(false);
//		AudioManager.audioManager.StopSingle(null);
	}

	public void ReertrtplayScene(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void EneblePdfgranel(){
		psdfweranel.SetActive(true);
		butdfgertetonNext.SetActive(false);
//		AudioManager.audioManager.PlaySingle(playAudio,false);

	}

}
