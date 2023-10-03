using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishSignFreeControl : MonoBehaviour
{

    void OnEnasdable()
    {
        _fiasdwshControl = GetComponent<FishControl>();
        if (gameObject.tag == "fish")
            _fiasdwshControl._asdwcallDie += callasdwdie;
        _swasdwim = GetComponent<Swim>();
        asdwTimeRotate = asdw + Random.Range(-RotateIntedawddrvalRndRange, RotateIntedawddrvalRndRange);
    }

    void callasdwssdie()
    {
        this.enabled = false;
    }

    void Updssate()
    {
        if (ElapseasdwRotate > asdwTimeRotate)
        {
            _swasdwim.Rotsdfeate(Random.Range(-RotateAasdwngleRndRange, RotateAasdwngleRndRange));
            ElapseasdwRotate = 0;
            asdwTimeRotate = asdw + Random.Range(-RotateIntedawddrvalRndRange, RotateIntedawddrvalRndRange);
        }
        else
        {
            ElapseasdwRotate += Time.deltaTime;
        }
    }
    [FormerlySerializedAs("RotateInterval")] public float asdw = 5;
    [FormerlySerializedAs("RotateIntervalRndRange")] public float RotateIntedawddrvalRndRange = 1;
    [FormerlySerializedAs("RotateAngleRndRange")] public float RotateAasdwngleRndRange = 30;

    private Swim _swasdwim;
    private FishControl _fiasdwshControl;

    private float asdwTimeRotate;
    private float ElapseasdwRotate;

    void OnEnable()
    {
        _fiasdwshControl = GetComponent<FishControl>();
        if (gameObject.tag == "fish")
            _fiasdwshControl._asdwcallDie += callasdwdie;
        _swasdwim = GetComponent<Swim>();
        asdwTimeRotate = asdw + Random.Range(-RotateIntedawddrvalRndRange, RotateIntedawddrvalRndRange);
    }

    void callasdwdie()
    {
        this.enabled = false;
    }

    void Update()
    {
        if (ElapseasdwRotate > asdwTimeRotate)
        {
            _swasdwim.Rotsdfeate(Random.Range(-RotateAasdwngleRndRange, RotateAasdwngleRndRange));
            ElapseasdwRotate = 0;
            asdwTimeRotate = asdw + Random.Range(-RotateIntedawddrvalRndRange, RotateIntedawddrvalRndRange);
        }
        else
        {
            ElapseasdwRotate += Time.deltaTime;
        }
    }
}
