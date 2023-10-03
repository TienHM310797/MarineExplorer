using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class changbonus : MonoBehaviour
{

    void OnEanable()
    {
        //  chil[Random.Range(0, chil.Length)].SetActive(true);
        chasdqil[0].SetActive(true);
    }
    void OnEndable()
    {
        //  chil[Random.Range(0, chil.Length)].SetActive(true);
        chasdqil[0].SetActive(true);
    }
    [FormerlySerializedAs("chil")] public GameObject[] chasdqil;

    void OnEnable()
    {
      //  chil[Random.Range(0, chil.Length)].SetActive(true);
        chasdqil[0].SetActive(true);
    }
}
