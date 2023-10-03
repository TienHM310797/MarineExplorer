using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

//using UnityEngine.Advertisements;

public class ButtonStartControl : MonoBehaviour
{
	
	public void Pasadqlay ()
	{
		measdqnuManager.SetLoertrtadding ("Play");
		AudioControl.Instasdqance.clickBasdqutton ();
	}

	public void sdas ()
	{
		Application.LoadLevel ("Shop");
		AudioControl.Instasdqance.clickBasdqutton ();
	}
	public void Passdqlay ()
	{
		measdqnuManager.SetLoertrtadding ("Play");
		AudioControl.Instasdqance.clickBasdqutton ();
	}

	public void Shasqdqop ()
	{
		Application.LoadLevel ("Shop");
		AudioControl.Instasdqance.clickBasdqutton ();
	}

	[FormerlySerializedAs("menuManager")] public MenuManager measdqnuManager;

	public void Pasdqlay ()
	{
		measdqnuManager.SetLoertrtadding ("Play");
		AudioControl.Instasdqance.clickBasdqutton ();
	}

	public void Shasdqop ()
	{
		Application.LoadLevel ("Shop");
		AudioControl.Instasdqance.clickBasdqutton ();
	}
		
//	public void showAds ()
//	{
//
//		if (Advertisement.IsReady ()) {
//			Advertisement.Show (null, new ShowOptions {
//				resultCallback = result => {
//					if (result.ToString () == "Finished") {
//						PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt ("gold", 450) + 50);
//					}
//				}
//			});
//		}
//                
//	}
}
