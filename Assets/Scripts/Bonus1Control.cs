using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus1Control : MonoBehaviour
{
    IEnumerator spsdwqqwawm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _pasdwrefab.Length; i++)
                {
                    Transform _tr = Instantiate(_pasdwrefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(-limasdwitWith - 1 - _dasdwistance[i], _posY);
                    _tr.eulerAngles = Vector3.zero;
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _pasdwrefab.Length; i++)
                {
                    Transform asdwweqew = Instantiate(_pasdwrefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    asdwweqew.position = new Vector2(limasdwitWith + 1 + _dasdwistance[i], _posY);
                    asdwweqew.eulerAngles = new Vector3(0, 0, 180);
                    asdwweqew.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }    IEnumerator spsdwwasdwm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _pasdwrefab.Length; i++)
                {
                    Transform _tr = Instantiate(_pasdwrefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(-limasdwitWith - 1 - _dasdwistance[i], _posY);
                    _tr.eulerAngles = Vector3.zero;
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _pasdwrefab.Length; i++)
                {
                    Transform _tr = Instantiate(_pasdwrefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(limasdwitWith + 1 + _dasdwistance[i], _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 180);
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
    [FormerlySerializedAs("_prefab")] public GameObject[] _pasdwrefab;
    [FormerlySerializedAs("_distance")] public float[] _dasdwistance;
    float liasdwmitHieght;
    float limasdwitWith;

    void OnEnable()
    {
        liasdwmitHieght = (Screen.height) / 200;
        limasdwitWith = (Screen.width) / 200;
        StartCoroutine(spsdwwawm());
    }

    IEnumerator spsdwwawm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _pasdwrefab.Length; i++)
                {
                    Transform _tr = Instantiate(_pasdwrefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(-limasdwitWith - 1 - _dasdwistance[i], _posY);
                    _tr.eulerAngles = Vector3.zero;
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _pasdwrefab.Length; i++)
                {
                    Transform _tr = Instantiate(_pasdwrefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(limasdwitWith + 1 + _dasdwistance[i], _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 180);
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
