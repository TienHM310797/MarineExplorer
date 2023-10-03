using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class ItemCountLb : MonoBehaviour
{

    
    void aStart()
    {
        asdq_lb = GetComponent<Text>();
    }

    void Updasdte()
    {
        asdq_lb.text = PlayerPrefs.GetInt(_sasdqtr,1) + "";
    }    void Starat()
    {
        asdq_lb = GetComponent<Text>();
    }

    void Updsdate()
    {
        asdq_lb.text = PlayerPrefs.GetInt(_sasdqtr,1) + "";
    }
    [FormerlySerializedAs("_str")] public string _sasdqtr;
	Text asdq_lb;

    void Start()
    {
		asdq_lb = GetComponent<Text>();
    }

    void Update()
    {
        asdq_lb.text = PlayerPrefs.GetInt(_sasdqtr,1) + "";
    }
}
