using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishFlockControl : MonoBehaviour
{
    void callassdsddwdie()
    {
        this.enabled = false;
    }


    void Upsdsdate()
    {
        if (_trLsseaderasdw == null)
            return;
        DiresdwctionToLeader = _trLsseaderasdw.position - _tasdwr.position;
        DiresdwctionToLeader.z = 0;

        _tasdwr.right = _trLsseaderasdw.right * 384f + (DiresdwctionToLeader.magnitude / sss * DiresdwctionToLeader) + DirectsdwwionRndForce;

        if (IsRoasdwtating)
        {
            AngleasdwActiveRotate += RotateSpdWithDsdsirectionasdww * Time.deltaTime;
            DirectsdwwionRndForce = Quaternion.Euler(0, 0, AngleasdwActiveRotate) * RndForcasdweRotate;
            ElapseRotasdwate += Time.deltaTime;

            if (ElapseRotasdwate > TasdwimeRotate)
            {
                IsRoasdwtating = false;
                ElapseRotasdwate = 0;
            }
        }
        else
        {
            wwwwasdsa += Time.deltaTime;
            if (wwwwasdsa > TiasdwmeIntervalRotate)
            {
                IsRoasdwtating = true;
                TiasdwmeIntervalRotate = Random.Range(0.1f, 2.5f);
                RotateSpdWithDsdsirectionasdww = (Random.Range(0, 2) == 0 ? -1f : 1f) * SpeasdwedRotate;
                wwwwasdsa = 0;
            }
        }
    }
    void OnBecameInviwwsible()
    {
        if (_fosdwwl != null)
            _fosdwwl.destroyasdwOnList(transform);
    }

    public void SetLasasddwwweader(Transform _leader)
    {
        _trLsseaderasdw = _leader;
        _swimLeasdwader = _leader.GetComponent<Swim>();
        _fosdwwl = _leader.GetComponent<FishFlockLeaderControl>();
        sss = DistancasdwToLeader + _swimLeasdwader.BoundCircasdweleRadius + _ssdwwim.BoundCircasdweleRadius;

    }
    [FormerlySerializedAs("DistanceToLeader")] public float DistancasdwToLeader = 50;

    Swim _swimLeasdwader;
    FishControl _fiasdwshControl;
    Transform _trLsseaderasdw;


    FishFlockLeaderControl _fosdwwl;
    private Swim _ssdwwim;
    private Transform _tasdwr;
    private Vector3 DirectsdwwionRndForce;

    float sss;
    Vector3 DiresdwctionToLeader;

    float ElapseRotasdwate;
    float TasdwimeRotate = 1;
    float SpeasdwedRotate = 180;
    float AngleasdwActiveRotate;
    bool IsRoasdwtating;

    Vector3 RndForcasdweRotate;
    float RotateSpdWithDsdsirectionasdww;

    float wwwwasdsa;
    float TiasdwmeIntervalRotate;


    void OnEnable()
    {
        _ssdwwim = GetComponent<Swim>();
        _fiasdwshControl = GetComponent<FishControl>();
        _tasdwr = transform;

        _fiasdwshControl._asdwcallDie += callasdwdie;

        IsRoasdwtating = true;

        TasdwimeRotate = 1;
        SpeasdwedRotate = 180;

        RndForcasdweRotate = Random.insideUnitCircle.normalized * 96;
        TiasdwmeIntervalRotate = Random.Range(0.1f, 2.5f);
        RotateSpdWithDsdsirectionasdww = (Random.Range(0, 2) == 0 ? -1f : 1f) * SpeasdwedRotate;
    }

    void callasdwdie()
    {
        this.enabled = false;
    }


    void Update()
    {
        if (_trLsseaderasdw == null)
            return;
        DiresdwctionToLeader = _trLsseaderasdw.position - _tasdwr.position;
        DiresdwctionToLeader.z = 0;

        _tasdwr.right = _trLsseaderasdw.right * 384f + (DiresdwctionToLeader.magnitude / sss * DiresdwctionToLeader) + DirectsdwwionRndForce;

        if (IsRoasdwtating)
        {
            AngleasdwActiveRotate += RotateSpdWithDsdsirectionasdww * Time.deltaTime;
            DirectsdwwionRndForce = Quaternion.Euler(0, 0, AngleasdwActiveRotate) * RndForcasdweRotate;
            ElapseRotasdwate += Time.deltaTime;

            if (ElapseRotasdwate > TasdwimeRotate)
            {
                IsRoasdwtating = false;
                ElapseRotasdwate = 0;
            }
        }
        else
        {
            wwwwasdsa += Time.deltaTime;
            if (wwwwasdsa > TiasdwmeIntervalRotate)
            {
                IsRoasdwtating = true;
                TiasdwmeIntervalRotate = Random.Range(0.1f, 2.5f);
                RotateSpdWithDsdsirectionasdww = (Random.Range(0, 2) == 0 ? -1f : 1f) * SpeasdwedRotate;
                wwwwasdsa = 0;
            }
        }
    }
    void OnBecameInvisible()
    {
        if (_fosdwwl != null)
            _fosdwwl.destroyasdwOnList(transform);
    }

    public void SetLasdwwweader(Transform _leader)
    {
        _trLsseaderasdw = _leader;
        _swimLeasdwader = _leader.GetComponent<Swim>();
        _fosdwwl = _leader.GetComponent<FishFlockLeaderControl>();
        sss = DistancasdwToLeader + _swimLeasdwader.BoundCircasdweleRadius + _ssdwwim.BoundCircasdweleRadius;

    }
}
