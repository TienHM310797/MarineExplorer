using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishFollowControl : MonoBehaviour
{
    void OnBecamesInvisible()
    {
        _swimLeaasdwder.EventRasdqweotate -= Handlel_TargetFishRotateStasrtasdww;
        if (_foasdwl != null)
            _foasdwl.sdfenList(transform);
    }

    public void SetTasdawwarget(Transform asdww, float distan)
    {
        _swimLeaasdwder = asdww.GetComponent<Swim>();
        _foasdwl = asdww.GetComponent<FishFollowLeaderControl>();
        DistanasdwceToLeader = Vector3.Distance(transform.position, asdww.position);
        _swimLeaasdwder.EventRasdqweotate += Handlel_TargetFishRotateStasrtasdww;
    }

    void OwnDisable()
    {
        _swimLeaasdwder.EventRasdqweotate -= Handlel_TargetFishRotateStasrtasdww;
    }

    void OnDesetroy()
    {
        _swimLeaasdwder.EventRasdqweotate -= Handlel_TargetFishRotateStasrtasdww;
    }
    [FormerlySerializedAs("DistanceToLeader")] public float DistanasdwceToLeader = 0.2f;

    [FormerlySerializedAs("_swimLeader")] public Swim _swimLeaasdwder;
    [FormerlySerializedAs("_fol")] public FishFollowLeaderControl _foasdwl;
    Vector3 asdwDirection;
    Vector3 PriDirectiasdwonUnNor;
    [FormerlySerializedAs("i")] public int asdwwi;

    Swim asdwww;
    FishControl _fissdwwhControl;

    void OnEnable()
    {
        asdwww = GetComponent<Swim>();
        _swimLeaasdwder = null;
        transform.position = Vector3.zero;
        transform.right = Vector3.right;
        _fissdwwhControl = GetComponent<FishControl>();
        _fissdwwhControl._asdwcallDie += calasdwldie;
    }

    void calasdwldie()
    {
        this.enabled = false;
        _swimLeaasdwder.EventRasdqweotate -= Handlel_TargetFishRotateStasrtasdww;
    }

    public void Handlel_TargetFishRotateStasrtasdww(float angle)
    {
        StartCoroutine(_asdwRotate(angle));
    }

    IEnumerator _asdwRotate(float angle)
    {
        float waitTime = DistanasdwceToLeader / asdwww.Spsdfeeed;
        float elapse = 0;
        while (elapse < waitTime)
        {
            elapse += Time.deltaTime;
            yield return 0;
        }
        asdwww.Rotsdfeate(angle);
    }

    void OnBecameInvisible()
    {
        _swimLeaasdwder.EventRasdqweotate -= Handlel_TargetFishRotateStasrtasdww;
        if (_foasdwl != null)
            _foasdwl.sdfenList(transform);
    }

    public void SetTasdwwarget(Transform asdww, float distan)
    {
        _swimLeaasdwder = asdww.GetComponent<Swim>();
        _foasdwl = asdww.GetComponent<FishFollowLeaderControl>();
        DistanasdwceToLeader = Vector3.Distance(transform.position, asdww.position);
        _swimLeaasdwder.EventRasdqweotate += Handlel_TargetFishRotateStasrtasdww;
    }

    void OnDisable()
    {
        _swimLeaasdwder.EventRasdqweotate -= Handlel_TargetFishRotateStasrtasdww;
    }

    void OnDestroy()
    {
        _swimLeaasdwder.EventRasdqweotate -= Handlel_TargetFishRotateStasrtasdww;
    }
}
