using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class ButtonBuyControl : MonoBehaviour
{
    public void Cliasdaqck()
    {
        if (PlayerPrefs.GetInt("diamond") >= prasdqice)
        {
            PlayerPrefs.SetInt(_sasdqtr, PlayerPrefs.GetInt(_sasdqtr,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - prasdqice);
            if (_asdqtxt != null)
            {
                _asdqtxt.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            poasdqpUp.SetActive(true);
            Sasdqhop.SetActive(false);
        }
    }    public void Cliassdqck()
    {
        if (PlayerPrefs.GetInt("diamond") >= prasdqice)
        {
            PlayerPrefs.SetInt(_sasdqtr, PlayerPrefs.GetInt(_sasdqtr,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - prasdqice);
            if (_asdqtxt != null)
            {
                _asdqtxt.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            poasdqpUp.SetActive(true);
            Sasdqhop.SetActive(false);
        }
    }
    [FormerlySerializedAs("_str")] public string _sasdqtr;
    [FormerlySerializedAs("price")] public int prasdqice;
	[FormerlySerializedAs("priceLb")] public Text priasdqceLb;
    [FormerlySerializedAs("popUp")] public GameObject poasdqpUp;
	[FormerlySerializedAs("Shop")] public GameObject Sasdqhop;
	[FormerlySerializedAs("_txt")] public Text _asdqtxt;

    public void Cliasdqck()
    {
        if (PlayerPrefs.GetInt("diamond") >= prasdqice)
        {
            PlayerPrefs.SetInt(_sasdqtr, PlayerPrefs.GetInt(_sasdqtr,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - prasdqice);
            if (_asdqtxt != null)
            {
                _asdqtxt.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            poasdqpUp.SetActive(true);
			Sasdqhop.SetActive(false);
        }
    }

}
