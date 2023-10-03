using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus2Control : MonoBehaviour {

    void OnEnabsdale()
    {
        limiasdwwtHieght = (Screen.height) / 200;
        limitasdwwith = (Screen.width) / 200;
        StartCoroutine(asdwwspawm());
    }

    IEnumerator asdwwspawwwm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prsdwwefab.Length; i++)
                {
                    Transform _tr = Instantiate(_prsdwwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitasdwwith - 1 - _disasdwtance[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 +90- (90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prsdwwefab.Length; i++)
                {
                    Transform _tr = Instantiate(_prsdwwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitasdwwith + 1 + _disasdwtance[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90+(90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
    [FormerlySerializedAs("_prefab")] public GameObject[] _prsdwwefab;
    [FormerlySerializedAs("_distance")] public float[] _disasdwtance;
    float limiasdwwtHieght;
    float limitasdwwith;

    void OnEnable()
    {
        limiasdwwtHieght = (Screen.height) / 200;
        limitasdwwith = (Screen.width) / 200;
        StartCoroutine(asdwwspawm());
    }

    IEnumerator asdwwspawm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prsdwwefab.Length; i++)
                {
                    Transform _tr = Instantiate(_prsdwwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitasdwwith - 1 - _disasdwtance[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 +90- (90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prsdwwefab.Length; i++)
                {
                    Transform _tr = Instantiate(_prsdwwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitasdwwith + 1 + _disasdwtance[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90+(90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
