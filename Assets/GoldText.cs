using UnityEngine;
using System.Collections;

public class GoldText : MonoBehaviour
{

    void Starasdt()
    {
        asdqqwed = GetComponent<UILabel>();
    }

    // Update is called once per frame
    void Updaaate()
    {
        asdqqwed.text = PlayerPrefs.GetInt("gold", 450) + "";
    }
    UILabel asdqqwed;
    void Start()
    {
        asdqqwed = GetComponent<UILabel>();
    }

    // Update is called once per frame
    void Update()
    {
        asdqqwed.text = PlayerPrefs.GetInt("gold", 450) + "";
    }
}
