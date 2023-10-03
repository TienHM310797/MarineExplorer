using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFollowLeaderControl : MonoBehaviour
{
    public void FollosdfesdawStart()
    {
        _swimasdq = GetComponent<Swim>();
        asdw = new List<Transform>();
        countFishasdw = Random.Range(xcvenCount, maxCsdfeount);
        for (int i = 0; i < countFishasdw; i++)
        {
            Transform _tr = Instantiate(_FishPasdwre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Distanasdw * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowControl>().SetTasdwwarget(transform, Vector3.Magnitude(transform.right * Distanasdw * i));
            _tr.GetComponent<Swim>().Spsdfeeed = _swimasdq.Spsdfeeed;
            asdw.Add(_tr);
        }
    }

    public void sdssfenList(Transform _trsdss)
    {


        if (asdw.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    List<Transform> asdw;
    int countFishasdw = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FishPasdwre;
    [FormerlySerializedAs("Distan")] public float Distanasdw = 0.5f;
    Swim _swimasdq;

    [FormerlySerializedAs("minCount")] public int xcvenCount;
    [FormerlySerializedAs("maxCount")] public int maxCsdfeount;

    public void FollosdfewStart()
    {
        _swimasdq = GetComponent<Swim>();
        asdw = new List<Transform>();
        countFishasdw = Random.Range(xcvenCount, maxCsdfeount);
        for (int i = 0; i < countFishasdw; i++)
        {
            Transform _tr = Instantiate(_FishPasdwre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Distanasdw * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowControl>().SetTasdwwarget(transform, Vector3.Magnitude(transform.right * Distanasdw * i));
            _tr.GetComponent<Swim>().Spsdfeeed = _swimasdq.Spsdfeeed;
            asdw.Add(_tr);
        }
    }

    public void sdfenList(Transform _trs)
    {
        asdw.Remove(_trs);

        if (asdw.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
