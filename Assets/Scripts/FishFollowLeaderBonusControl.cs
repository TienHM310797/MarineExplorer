using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFollowLeaderBonusControl : MonoBehaviour
{
    public void FollsdwwwosswStart()
    {
        _sdwwwswim = GetComponent<Swim>();

        _fasdwish = new List<Transform>();
        for (int i = 0; i < countFasdwish; i++)
        {
            Transform _tr = Instantiate(_FwwishPreasdw).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * asdwDistan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SetTargedfgrt(transform, Vector3.Magnitude(transform.right * asdwDistan * i));
            _tr.GetComponent<Swim>().Spsdfeeed = _sdwwwswim.Spsdfeeed;
            _fasdwish.Add(_tr);
        }
    }

    public void destrosdssqwyOnList(Transform _trs)
    {
        _fasdwish.Remove(_trs);

        if (_fasdwish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    List<Transform> _fasdwish;
    [FormerlySerializedAs("countFish")] public int countFasdwish = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FwwishPreasdw;
    [FormerlySerializedAs("Distan")] public float asdwDistan = 0.5f;
    Swim _sdwwwswim;

    public void FollsdwwwowStart()
    {
        _sdwwwswim = GetComponent<Swim>();

        _fasdwish = new List<Transform>();
        for (int i = 0; i < countFasdwish; i++)
        {
            Transform _tr = Instantiate(_FwwishPreasdw).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * asdwDistan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SetTargedfgrt(transform, Vector3.Magnitude(transform.right * asdwDistan * i));
            _tr.GetComponent<Swim>().Spsdfeeed = _sdwwwswim.Spsdfeeed;
            _fasdwish.Add(_tr);
        }
    }

    public void destrosdqwyOnList(Transform _trs)
    {
        _fasdwish.Remove(_trs);

        if (_fasdwish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
