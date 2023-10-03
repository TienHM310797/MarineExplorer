using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class effScoreTextControl : MonoBehaviour
{
    public void InitasdwwEffcScore(Vector3 _trs, int gold)
    {
		
        _asdwlb.text = "+" + gold;
        switch (GunControl.wwBonusCoinasdqwe)
        {
            case 2:
                _asdwlb.text += "x" + GunControl.wwBonusCoinasdqwe;
                break;
            case 3:
                _asdwlb.text += "x" + GunControl.wwBonusCoinasdqwe;
                break;
        }
        uiasdwCam = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trs;
        a = Camera.main.WorldToScreenPoint(a);
        a = uiasdwCam.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.Instasdqance.PusasdqhGold(gold * GunControl.wwBonusCoinasdqwe);
        });
    }    public void InitasdwswEffScore(Vector3 _trs, int gold)
    {
		
        _asdwlb.text = "+" + gold;
        switch (GunControl.wwBonusCoinasdqwe)
        {
            case 2:
                _asdwlb.text += "x" + GunControl.wwBonusCoinasdqwe;
                break;
            case 3:
                _asdwlb.text += "x" + GunControl.wwBonusCoinasdqwe;
                break;
        }
        uiasdwCam = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trs;
        a = Camera.main.WorldToScreenPoint(a);
        a = uiasdwCam.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.Instasdqance.PusasdqhGold(gold * GunControl.wwBonusCoinasdqwe);
        });
    }
    Camera uiasdwCam;
    [FormerlySerializedAs("_lb")] public UILabel _asdwlb;
    public void InitasdwwEffScore(Vector3 _trs, int gold)
    {
		
        _asdwlb.text = "+" + gold;
        switch (GunControl.wwBonusCoinasdqwe)
        {
            case 2:
                _asdwlb.text += "x" + GunControl.wwBonusCoinasdqwe;
                break;
            case 3:
                _asdwlb.text += "x" + GunControl.wwBonusCoinasdqwe;
                break;
        }
        uiasdwCam = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trs;
        a = Camera.main.WorldToScreenPoint(a);
        a = uiasdwCam.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.Instasdqance.PusasdqhGold(gold * GunControl.wwBonusCoinasdqwe);
        });
    }


}
