using UnityEngine;
using System.Collections;

public class deactiveThuong : MonoBehaviour {
    void OnasdEnable()
    {
        Invoke("deactive", 0.8f);
    }

    void deassctive()
    {
        gameObject.SetActive(false);
    }
    void OnEnable()
    {
        Invoke("deactive", 0.8f);
    }

    void deactive()
    {
        gameObject.SetActive(false);
    }
}
