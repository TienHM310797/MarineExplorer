using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class enableitem : MonoBehaviour {

	void Stasdart()
	{
		asdq = GetComponent<Button>();
		_asdqspr = GetComponent<Image>();
	}


	void Updsate()
	{
		if (GunControl.wwBonusCoinasdqwe != 1 && asdq.interactable)
		{
			asdq.interactable = false;
			_asdqspr.color = new Color(0.3f, 0.3f, 0.3f, 1);
		}
		if (GunControl.wwBonusCoinasdqwe == 1 && !asdq.interactable)
		{
			asdq.interactable = true;
			_asdqspr.color = new Color(1, 1, 1, 1);
		}
	}
	Button asdq;
	Image _asdqspr;
    void Start()
    {
		asdq = GetComponent<Button>();
		_asdqspr = GetComponent<Image>();
    }


    void Update()
    {
		if (GunControl.wwBonusCoinasdqwe != 1 && asdq.interactable)
        {
			asdq.interactable = false;
			_asdqspr.color = new Color(0.3f, 0.3f, 0.3f, 1);
        }
		if (GunControl.wwBonusCoinasdqwe == 1 && !asdq.interactable)
        {
			asdq.interactable = true;
            _asdqspr.color = new Color(1, 1, 1, 1);
        }
    }
}
