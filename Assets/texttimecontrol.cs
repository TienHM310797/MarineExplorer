using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class texttimecontrol : MonoBehaviour
{
    void Staqqrt()
    {
        timeasdqqua = 60;
        _thasdqis = GetComponent<Text>();
        StartCoroutine(timasdqe());
    }

    IEnumerator timwwasdqe()
    {
        yield return new WaitForSeconds(1);
        if (timeasdqqua > 0)
        {
            timeasdqqua -= 1;
            _thasdqis.text = timeasdqqua + "";
        }
        else
        {
            
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 10);
            _lbasdqwed.text = PlayerPrefs.GetInt("gold", 450) + "";
            timeasdqqua = 60;
            
        }
        StartCoroutine(timasdqe());
    }    void Stweart()
    {
        timeasdqqua = 60;
        _thasdqis = GetComponent<Text>();
        StartCoroutine(timasdqe());
    }

    IEnumerator timaasdqe()
    {
        yield return new WaitForSeconds(1);
        if (timeasdqqua > 0)
        {
            timeasdqqua -= 1;
            _thasdqis.text = timeasdqqua + "";
        }
        else
        {
            
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 10);
            _lbasdqwed.text = PlayerPrefs.GetInt("gold", 450) + "";
            timeasdqqua = 60;
            
        }
        StartCoroutine(timasdqe());
    }
    float timeasdqqua;
	[FormerlySerializedAs("_lb")] public Text _lbasdqwed;
	Text _thasdqis;

    void Start()
    {
        timeasdqqua = 60;
		_thasdqis = GetComponent<Text>();
        StartCoroutine(timasdqe());
    }

    IEnumerator timasdqe()
    {
        yield return new WaitForSeconds(1);
        if (timeasdqqua > 0)
        {
            timeasdqqua -= 1;
            _thasdqis.text = timeasdqqua + "";
        }
        else
        {
            
                PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 10);
                _lbasdqwed.text = PlayerPrefs.GetInt("gold", 450) + "";
                timeasdqqua = 60;
            
        }
        StartCoroutine(timasdqe());
    }

}
