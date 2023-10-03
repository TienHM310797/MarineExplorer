using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFlockLeaderControl : MonoBehaviour
{
    public void FloasdwckSsdstart()
    {
        _fishasdw = new List<Transform>();
        countasdwFish = Random.Range(minCasdwount, maxCoasdwunt);
        for (int i = 0; i < countasdwFish; i++)
        {
            Transform _tr = Instantiate(_FisasdwhPre).transform;
            _tr.GetComponent<FishFlockControl>().SetLasdwwweader(transform);
            _fishasdw.Add(_tr);
            _tr.position = new Vector2(transform.position.x, transform.position.y) + Random.insideUnitCircle * 0.8f;
            // FishManage.Instance._FishMange.Add(_tr);
        }
    }

    public void destroyasdqqwOnList(Transform _trs)
    {
        _fishasdw.Remove(_trs);

        if (_fishasdw.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    List<Transform> _fishasdw;
    int countasdwFish = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FisasdwhPre;

    [FormerlySerializedAs("minCount")] public int minCasdwount;
    [FormerlySerializedAs("maxCount")] public int maxCoasdwunt;

    public void FloasdwckStart()
    {
        _fishasdw = new List<Transform>();
        countasdwFish = Random.Range(minCasdwount, maxCoasdwunt);
        for (int i = 0; i < countasdwFish; i++)
        {
            Transform _tr = Instantiate(_FisasdwhPre).transform;
            _tr.GetComponent<FishFlockControl>().SetLasdwwweader(transform);
            _fishasdw.Add(_tr);
            _tr.position = new Vector2(transform.position.x, transform.position.y) + Random.insideUnitCircle * 0.8f;
           // FishManage.Instance._FishMange.Add(_tr);
        }
    }

    public void destroyasdwOnList(Transform _trs)
    {
        _fishasdw.Remove(_trs);

        if (_fishasdw.Count == 0)
        {
                Destroy(gameObject);
        }
    }
}
