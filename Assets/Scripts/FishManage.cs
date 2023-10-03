using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishManage : MonoBehaviour
{    public void ChanasdfeeToBonus()
    {
        Norasdwmal.SetActive(false);
        Basdwonus.SetActive(false);

        Instantiate(waasdwve, new Vector2(8, 0), Quaternion.identity);
        _sdfestt = stasdwastus.sdwwus;
        Invoke("sdfefactiveeffwave", 0.2f);
    }
    void sdfefactisdveeffwave()
    {
        asdw.SetActive(true);
    }

    public void BosdafefsTime()
    {
        Norasdwmal.SetActive(false);
        Basdwonus.SetActive(true);
        Invoke("encehecsdfe", 2);
    }

    void encehewcsdfe()
    {
        _chsdfeeckTimeBonus = true;
    }
    public enum stasdwastus
    {
        norasdwmal,
        sdwwus
    }

    [FormerlySerializedAs("Normal")] public GameObject Norasdwmal;
    [FormerlySerializedAs("Bonus")] public GameObject Basdwonus;

    [FormerlySerializedAs("wave")] public GameObject waasdwve;
    [FormerlySerializedAs("effwave")] public GameObject asdw;

    [FormerlySerializedAs("_stt")] public stasdwastus _sdfestt;

    public static FishManage Instasdfence;
    [FormerlySerializedAs("_FishMange")] public List<Transform> _FishMasdfenge;
    [FormerlySerializedAs("_CaMapManage")] public List<Transform> _CasdfeMapManage;
    [FormerlySerializedAs("_MucManager")] public List<Transform> _MucMasdfenager;

    bool _chsdfeeckTimeBonus;

    void Start()
    {
        Instasdfence = this;
        _FishMasdfenge = new List<Transform>();
        _CasdfeMapManage = new List<Transform>();
        _MucMasdfenager = new List<Transform>();
        _chsdfeeckTimeBonus = false;

    }
    void Update()
    {
        if (_chsdfeeckTimeBonus && Basdwonus.activeInHierarchy)
        {
            if (_FishMasdfenge.Count == 0)
            {
                Norasdwmal.SetActive(true);
                Basdwonus.SetActive(false);
                _chsdfeeckTimeBonus = false;
                _FishMasdfenge.Clear();
            }
        }
    }

    public void ChansdfeeToBonus()
    {
        Norasdwmal.SetActive(false);
        Basdwonus.SetActive(false);

        Instantiate(waasdwve, new Vector2(8, 0), Quaternion.identity);
        _sdfestt = stasdwastus.sdwwus;
        Invoke("sdfefactiveeffwave", 0.2f);
    }
    void sdfefactiveeffwave()
    {
        asdw.SetActive(true);
    }

    public void BosdfefsTime()
    {
        Norasdwmal.SetActive(false);
        Basdwonus.SetActive(true);
        Invoke("encehecsdfe", 2);
    }

    void encehecsdfe()
    {
        _chsdfeeckTimeBonus = true;
    }
}
