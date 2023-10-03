using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus3Control : MonoBehaviour
{
    IEnumerator sasdsdswpawm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prasdwefab.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prasdwefab.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prasdwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitasdwwwWith - 1 - _distanceasdww[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 + 90 - (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prasdwefab.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prasdwefab.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prasdwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitasdwwwWith + 1 + _distanceasdww[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90 + (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }    IEnumerator sasdwspawm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prasdwefab.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prasdwefab.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prasdwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitasdwwwWith - 1 - _distanceasdww[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 + 90 - (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prasdwefab.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prasdwefab.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prasdwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitasdwwwWith + 1 + _distanceasdww[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90 + (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
    [FormerlySerializedAs("_prefab")] public GameObject[] _prasdwefab;
    [FormerlySerializedAs("_distance")] public float[] _distanceasdww;
    float limasdwitHieght;
    float limitasdwwwWith;

    void OnEnable()
    {
        limasdwitHieght = (Screen.height) / 200;
        limitasdwwwWith = (Screen.width) / 200;
        StartCoroutine(sasdwpawm());
    }

    IEnumerator sasdwpawm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prasdwefab.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prasdwefab.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prasdwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitasdwwwWith - 1 - _distanceasdww[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 + 90 - (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prasdwefab.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prasdwefab.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prasdwefab[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitasdwwwWith + 1 + _distanceasdww[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90 + (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollsdwwwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
