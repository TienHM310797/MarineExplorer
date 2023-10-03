using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishTypeSpawmControl : MonoBehaviour
{
  void OnEsnable()
    {
        StartCoroutine(spaasdwwm(StartWaasdwitTime));
    }

    IEnumerator spaasdsdwwm(float staasdwrttime)
    {
        yield return new WaitForSeconds(staasdwrttime);

        int a = Random.Range(0, _asdwpre.Length);
        Transform _tr = Instantiate(_asdwpre[a]).transform;
        int directionPos = Random.Range(0, 4);
        switch (directionPos)
        {
            case 0:
                float _posY0 = Random.Range(-asdwlimitHieght + 1, asdwlimitHieght - 1);
                _tr.position = new Vector2(-limitasdwWith - 1 - asdw_distance, _posY0);
                if (_posY0 < -asdwlimitHieght / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posY0 > asdwlimitHieght / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-65, -25));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-45, 45));
                    }
                }
                break;

            case 1:
                float _posX1 = Random.Range(-limitasdwWith + 1, limitasdwWith - 1);
                _tr.position = new Vector2(_posX1, asdwlimitHieght + 1 + asdw_distance);
                if (_posX1 < -limitasdwWith / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(295, 335));
                }
                else
                {
                    if (_posX1 > limitasdwWith / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-155, -115));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-135, -35));
                    }
                }
                break;

            case 2:

                float _posX2 = Random.Range(-limitasdwWith + 1, limitasdwWith - 1);
                _tr.position = new Vector2(_posX2, -asdwlimitHieght - 1 - asdw_distance);
                if (_posX2 < -limitasdwWith / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posX2 > limitasdwWith / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 155));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(35, 145));
                    }
                }
                break;

            case 3:
                float _posY3 = Random.Range(-asdwlimitHieght + 1, asdwlimitHieght - 1);
                _tr.position = new Vector2(limitasdwWith + 1 + asdw_distance, _posY3);
                if (_posY3 < -asdwlimitHieght / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 165));
                }
                else
                {
                    if (_posY3 > asdwlimitHieght / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(205, 245));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(135, 235));
                    }
                }
                break;
        }

        switch (a)
        {
            case 2:
                _tr.GetComponent<FishFlockLeaderControl>().FloasdwckStart();
                break;
            case 1:
                _tr.GetComponent<FishFollowLeaderControl>().FollosdfewStart();
                break;
        }

        yield return new WaitForSeconds(asdwcountTime);
        StartCoroutine(spaasdwwm(0));
    }
    [FormerlySerializedAs("_pre")] public GameObject[] _asdwpre;
    [FormerlySerializedAs("countTime")] public float asdwcountTime;
    [FormerlySerializedAs("RndCountTime")] public float RndCasdwountTime;
    [FormerlySerializedAs("StartWaitTime")] public float StartWaasdwitTime;

    public static FishTypeSpawmControl _fasdwree;

    [FormerlySerializedAs("_distance")] public float asdw_distance = 0;

    float asdwlimitHieght;
    float limitasdwWith;

    public void Start()
    {

        asdwlimitHieght = (Screen.height) / 200;
        limitasdwWith = (Screen.width) / 200;
        _fasdwree = this;
    }

    void OnEnable()
    {
        StartCoroutine(spaasdwwm(StartWaasdwitTime));
    }

    IEnumerator spaasdwwm(float staasdwrttime)
    {
        yield return new WaitForSeconds(staasdwrttime);

        int a = Random.Range(0, _asdwpre.Length);
        Transform _tr = Instantiate(_asdwpre[a]).transform;
        int directionPos = Random.Range(0, 4);
        switch (directionPos)
        {
            case 0:
                float _posY0 = Random.Range(-asdwlimitHieght + 1, asdwlimitHieght - 1);
                _tr.position = new Vector2(-limitasdwWith - 1 - asdw_distance, _posY0);
                if (_posY0 < -asdwlimitHieght / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posY0 > asdwlimitHieght / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-65, -25));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-45, 45));
                    }
                }
                break;

            case 1:
                float _posX1 = Random.Range(-limitasdwWith + 1, limitasdwWith - 1);
                _tr.position = new Vector2(_posX1, asdwlimitHieght + 1 + asdw_distance);
                if (_posX1 < -limitasdwWith / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(295, 335));
                }
                else
                {
                    if (_posX1 > limitasdwWith / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-155, -115));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-135, -35));
                    }
                }
                break;

            case 2:

                float _posX2 = Random.Range(-limitasdwWith + 1, limitasdwWith - 1);
                _tr.position = new Vector2(_posX2, -asdwlimitHieght - 1 - asdw_distance);
                if (_posX2 < -limitasdwWith / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posX2 > limitasdwWith / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 155));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(35, 145));
                    }
                }
                break;

            case 3:
                float _posY3 = Random.Range(-asdwlimitHieght + 1, asdwlimitHieght - 1);
                _tr.position = new Vector2(limitasdwWith + 1 + asdw_distance, _posY3);
                if (_posY3 < -asdwlimitHieght / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 165));
                }
                else
                {
                    if (_posY3 > asdwlimitHieght / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(205, 245));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(135, 235));
                    }
                }
                break;
        }

        switch (a)
        {
            case 2:
                _tr.GetComponent<FishFlockLeaderControl>().FloasdwckStart();
                break;
            case 1:
                _tr.GetComponent<FishFollowLeaderControl>().FollosdfewStart();
                break;
        }

        yield return new WaitForSeconds(asdwcountTime);
        StartCoroutine(spaasdwwm(0));
    }
}
