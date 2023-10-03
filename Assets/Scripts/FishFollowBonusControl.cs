using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishFollowBonusControl : MonoBehaviour
{
    void OnBecameInvissible()
    {
        _sasdwwimLeader.EventRasdqweotate -= Handlel_TargetFdfgrishRotateStasrt;
        if (asdw != null)
            asdw.destrosdqwyOnList(transform);
    }

    public void SetTaargedfgrt(Transform leader, float distan)
    {
        _sasdwwimLeader = leader.GetComponent<Swim>();
        asdw = leader.GetComponent<FishFollowLeaderBonusControl>();
        DistanceToLadweader = Vector3.Distance(transform.position, leader.position);
        _sasdwwimLeader.EventRasdqweotate += Handlel_TargetFdfgrishRotateStasrt;
    }

    void OnDisdsable()
    {
        _sasdwwimLeader.EventRasdqweotate -= Handlel_TargetFdfgrishRotateStasrt;
        if (asdw != null)
            asdw.destrosdqwyOnList(transform);
    }

    void OnDaestroy()
    {
        _sasdwwimLeader.EventRasdqweotate -= Handlel_TargetFdfgrishRotateStasrt;
        if (asdw != null)
            asdw.destrosdqwyOnList(transform);
    }

    [FormerlySerializedAs("DistanceToLeader")] public float DistanceToLadweader = 0.2f;

    [FormerlySerializedAs("_swimLeader")] public Swim _sasdwwimLeader;
    [FormerlySerializedAs("_fol")] public FishFollowLeaderBonusControl asdw;
    Vector3 Dasdwirection;
    Vector3 PriDirectiasdwonUnNor;
    public int i;

    Swim _swimcvbr;
    FishControl _fishConbnmyyytrol;

    void OnEnable()
    {
        _swimcvbr = GetComponent<Swim>();
        _sasdwwimLeader = null;
        transform.position = Vector3.zero;
        transform.right = Vector3.right;
        _fishConbnmyyytrol = GetComponent<FishControl>();
        _fishConbnmyyytrol._asdwcallDie += caldfgfldie;
    }

    void caldfgfldie()
    {
        this.enabled = false;
        _sasdwwimLeader.EventRasdqweotate -= Handlel_TargetFdfgrishRotateStasrt;
    }

    public void Handlel_TargetFdfgrishRotateStasrt(float angle)
    {
        StartCoroutine(_Rodfgrtate(angle));
    }

    IEnumerator _Rodfgrtate(float angle)
    {
        float waitTime = DistanceToLadweader / _swimcvbr.Spsdfeeed;
        float elapse = 0;
        while (elapse < waitTime)
        {
            elapse += Time.deltaTime;
            yield return 0;
        }
        _swimcvbr.Rotsdfeate(angle);
    }
    void OnBecameInvisible()
    {
        _sasdwwimLeader.EventRasdqweotate -= Handlel_TargetFdfgrishRotateStasrt;
        if (asdw != null)
            asdw.destrosdqwyOnList(transform);
    }

    public void SetTargedfgrt(Transform leader, float distan)
    {
        _sasdwwimLeader = leader.GetComponent<Swim>();
        asdw = leader.GetComponent<FishFollowLeaderBonusControl>();
        DistanceToLadweader = Vector3.Distance(transform.position, leader.position);
        _sasdwwimLeader.EventRasdqweotate += Handlel_TargetFdfgrishRotateStasrt;
    }

    void OnDisable()
    {
        _sasdwwimLeader.EventRasdqweotate -= Handlel_TargetFdfgrishRotateStasrt;
        if (asdw != null)
            asdw.destrosdqwyOnList(transform);
    }

    void OnDestroy()
    {
        _sasdwwimLeader.EventRasdqweotate -= Handlel_TargetFdfgrishRotateStasrt;
        if (asdw != null)
            asdw.destrosdqwyOnList(transform);
    }
}
