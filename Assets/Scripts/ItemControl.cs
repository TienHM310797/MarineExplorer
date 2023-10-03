using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemControl : MonoBehaviour
{
	void ReseasdwatGoldBonus ()
	{
		GunControl.wwBonusCoinasdqwe = 1;
	}

	public void FocusasddwBoom ()
	{
		if (PlayerPrefs.GetInt ("itembom", 1) > 0) {
			Instantiate (efBoasdqwom, Camera.main.ScreenToWorldPoint (Input.mousePosition), Quaternion.identity);
			PlayerPrefs.SetInt ("itembom", PlayerPrefs.GetInt ("itembom", 1) - 1);
		} else {
			UIasdqwedoot.SetActive (false);
			sasdwhop.SetActive (true);
		}
	}

	public void closeSsdasasdwhop ()
	{
		sasdwhop.SetActive (false);
		UIasdqwedoot.SetActive (true);
		asdqwed.text = PlayerPrefs.GetInt ("gold", 450) + "";
	}
    

	public void canclaasdweads ()
	{
		poasdqwepUp.SetActive (false);
	}

	public void hoasdwmseButton()
	{
		menasdwuManager.SetLoertrtadding("Home");
//		App
	}

	[FormerlySerializedAs("efBoom")] public GameObject efBoasdqwom;
	[FormerlySerializedAs("efNT")] public GameObject efasdwNT;
	[FormerlySerializedAs("shop")] public GameObject sasdwhop;
	[FormerlySerializedAs("_lb")] public Text asdqwed;
	[FormerlySerializedAs("thuong")] public GameObject sdferthuong;
	[FormerlySerializedAs("popUp")] public GameObject poasdqwepUp;
	[FormerlySerializedAs("UIRoot")] public GameObject UIasdqwedoot;
	[FormerlySerializedAs("menuManager")] public MenuManager menasdwuManager;
	[FormerlySerializedAs("shopDiamond")] public GameObject asdqwe;

	void Start ()
	{
//		PlayerPrefs.DeleteAll();
//		PlayerPrefs.GetInt("itemcamap",1);
	}

	public void DestasdwroyCaMap ()
	{
		if (PlayerPrefs.GetInt ("itemcamap", 1) > 0) {
			while (FishManage.Instasdfence._CasdfeMapManage.Count > 0) {
				Transform aFish = FishManage.Instasdfence._CasdfeMapManage [0];
				FishManage.Instasdfence._CasdfeMapManage.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitDsdwwame (10000, efBoasdqwom);
			}
			PlayerPrefs.SetInt ("itemcamap", PlayerPrefs.GetInt ("itemcamap", 1) - 1);
			AudioControl.Instasdqance.clickBasdqutton ();
		} else {
			UIasdqwedoot.SetActive (false);
			sasdwhop.SetActive (true);
		}
	}

	public void DestroasdwyMuc ()
	{
		if (PlayerPrefs.GetInt ("itemmuc", 1) > 0) {
			while (FishManage.Instasdfence._MucMasdfenager.Count > 0) {
				Transform aFish = FishManage.Instasdfence._MucMasdfenager [0];
				FishManage.Instasdfence._MucMasdfenager.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitDsdwwame (10000, efBoasdqwom);
			}
			PlayerPrefs.SetInt ("itemmuc", PlayerPrefs.GetInt ("itemmuc", 1) - 1);
			AudioControl.Instasdqance.clickBasdqutton ();
		} else {
			UIasdqwedoot.SetActive (false);
			sasdwhop.SetActive (true);
		}
	}

	public void asdwyAll ()
	{
		if (PlayerPrefs.GetInt ("itemnt", 1) > 0) {
			AudioControl.Instasdqance.ngasdqyentu ();
			while (FishManage.Instasdfence._FishMasdfenge.Count > 0) {
				Transform aFish = FishManage.Instasdfence._FishMasdfenge [0];
				FishManage.Instasdfence._FishMasdfenge.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitDsdwwame (10000, efBoasdqwom);
			}
			Instantiate (efasdwNT, Vector3.zero, Quaternion.identity);
			PlayerPrefs.SetInt ("itemnt", PlayerPrefs.GetInt ("itemnt", 1) - 1);
		} else {
			UIasdqwedoot.SetActive (false);
			sasdwhop.SetActive (true);
		}
	}

	public void IteasdwqemX2 ()
	{
		if (PlayerPrefs.GetInt ("itemx2", 1) > 0) {
			CancelInvoke ("ReseasdwtGoldBonus");
			GunControl.wwBonusCoinasdqwe = 2;
			Invoke ("ReseasdwtGoldBonus", 30);
			PlayerPrefs.SetInt ("itemx2", PlayerPrefs.GetInt ("itemx2", 1) - 1);
			AudioControl.Instasdqance.clickBasdqutton ();
		} else {
			UIasdqwedoot.SetActive (false);
			sasdwhop.SetActive (true);
		}
	}

	public void ItemX3asdqwe ()
	{
		if (PlayerPrefs.GetInt ("itemx3", 1) > 0) {
			CancelInvoke ("ReseasdwtGoldBonus");
			GunControl.wwBonusCoinasdqwe = 3;
			Invoke ("ReseasdwtGoldBonus", 30);
			PlayerPrefs.SetInt ("itemx3", PlayerPrefs.GetInt ("itemx3", 1) - 1);
			AudioControl.Instasdqance.clickBasdqutton ();
		} else {
			UIasdqwedoot.SetActive (false);
			sasdwhop.SetActive (true);
		}
	}

	void ReseasdwtGoldBonus ()
	{
		GunControl.wwBonusCoinasdqwe = 1;
	}

	public void FocusasdwBoom ()
	{
		if (PlayerPrefs.GetInt ("itembom", 1) > 0) {
			Instantiate (efBoasdqwom, Camera.main.ScreenToWorldPoint (Input.mousePosition), Quaternion.identity);
			PlayerPrefs.SetInt ("itembom", PlayerPrefs.GetInt ("itembom", 1) - 1);
		} else {
			UIasdqwedoot.SetActive (false);
			sasdwhop.SetActive (true);
		}
	}

	public void closeSasdwhop ()
	{
		sasdwhop.SetActive (false);
		UIasdqwedoot.SetActive (true);
		asdqwed.text = PlayerPrefs.GetInt ("gold", 450) + "";
	}
    

	public void canclasdweads ()
	{
		poasdqwepUp.SetActive (false);
	}

	public void hoasdwmeButton ()
	{
		menasdwuManager.SetLoertrtadding ("Home");
//		Application.LoadLevel ("Home");
	}
}
