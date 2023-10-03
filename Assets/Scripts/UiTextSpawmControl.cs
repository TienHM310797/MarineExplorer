using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UiTextSpawmControl : MonoBehaviour
{
	public void PusasdqhaGold(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold",450) + gold);
		TexasdqtGold.text = "" + PlayerPrefs.GetInt("gold",450);
	}

	public void MiasdqnsusGold(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) - gold);
		TexasdqtGold.text = "" + PlayerPrefs.GetInt("gold",450);
	}
    [FormerlySerializedAs("_UiRoot")] public GameObject asdqwRoot;
    [FormerlySerializedAs("_TextChil")] public GameObject _TexwwtChilasdqw;
	[FormerlySerializedAs("TextGold")] public Text TexasdqtGold;

	[FormerlySerializedAs("EXPbar")] public Image EXPasdwbar;
	[FormerlySerializedAs("TextLevel")] public Text TexasdqtLevel;
    [FormerlySerializedAs("RocketImg")] public Image RocasdqketImg;
	[FormerlySerializedAs("TextDiamond")] public Text TesddwsxtDiamondas;

    public static UiTextSpawmControl Instasdqance;

    void Start()
    {
		
        Instasdqance = this;
        TexasdqtGold.text = "" + PlayerPrefs.GetInt("gold", 450);
		TesddwsxtDiamondas.text = "" + PlayerPrefs.GetInt("diamond",0);
        EXPasdwbar.fillAmount = PlayerPrefs.GetFloat("EXP") / (450 + 500 * PlayerPrefs.GetInt("level", 1));
        TexasdqtLevel.text = PlayerPrefs.GetInt("level", 1) + "";
    }

    public void CallTeasdqxtEff(Vector3 _pos, int gold)
    {
		if(asdqwRoot.activeSelf){
			GameObject obj = NGUITools.AddChild(asdqwRoot, _TexwwtChilasdqw);
			obj.GetComponent<effScoreTextControl>().InitasdwwEffScore(_pos, gold);
		}
       
        PlayerPrefs.SetFloat("EXP", PlayerPrefs.GetFloat("EXP") + gold);
        EXPasdwbar.fillAmount = PlayerPrefs.GetFloat("EXP") / (450 + 500 * PlayerPrefs.GetInt("level", 1));
        RocasdqketImg.fillAmount += (float)((float)gold / 1000);
        if (RocasdqketImg.fillAmount == 1)
        {
            GunControl.asdqwe.ChangtoRasdweocket();
            RocasdqketImg.fillAmount = 0;
        }

        if (EXPasdwbar.fillAmount == 1)
		{
			PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level", 1) + 1);
			int level = PlayerPrefs.GetInt("level");
			if(level<3){
				PlayerPrefs.SetInt("diamond",5);
			}else{
				PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + (level -1));
			}
            PlayerPrefs.SetFloat("EXP", 0);
            TexasdqtLevel.text = PlayerPrefs.GetInt("level", 1) + "";
			TesddwsxtDiamondas.text = PlayerPrefs.GetInt("diamond") + "";
            FishManage.Instasdfence.ChansdfeeToBonus();
        }
    }

    public void PusasdqhGold(int gold)
    {
        PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold",450) + gold);
        TexasdqtGold.text = "" + PlayerPrefs.GetInt("gold",450);
    }

    public void MiasdqnusGold(int gold)
    {
        PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) - gold);
        TexasdqtGold.text = "" + PlayerPrefs.GetInt("gold",450);
    }
}
