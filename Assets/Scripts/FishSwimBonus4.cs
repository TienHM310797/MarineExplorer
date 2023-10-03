using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishSwimBonus4 : MonoBehaviour
{
    public void asdwStaeerstBonus4(float asdw, float directionasdw)
    {
        asdweda = GetComponent<Swim>();
        asdweda.Spsdfeeed = ((Mathf.PI * asdw) / 5);
        asdweda.RotaxcveteSpeed = 38;
        this.asdw = new List<Transform>();
        for (int i = 0; i < coxcveduntFish; i++)
        {
            Transform _tr = Instantiate(_FishxcvdPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Distazxdcfen * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SetTargedfgrt(transform, Vector3.Magnitude(transform.right * Distazxdcfen * i));
            _tr.GetComponent<Swim>().Spsdfeeed = asdweda.Spsdfeeed;
            _tr.GetComponent<Swim>().RotaxcveteSpeed = 38;
            if (directionasdw == 0)
                _tr.gameObject.AddComponent<SwinRotationBonus>().asdqwervfc = 270;
            else
                _tr.gameObject.AddComponent<SwinRotationBonus>().asdqwervfc = 90;
            this.asdw.Add(_tr);
        }
        Destroy(gameObject);
    }

    void Updaate()
    {
        // transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, 270), 180 * Time.deltaTime / 5);
    }

    public void desstroasdwyOnList(Transform _trs)
    {
        asdw.Remove(_trs);

        if (asdw.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    Swim asdweda;

    List<Transform> asdw;
    [FormerlySerializedAs("countFish")] public int coxcveduntFish = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FishxcvdPre;
    [FormerlySerializedAs("Distan")] public float Distazxdcfen = 0.5f;

    public void asdwStaeertBonus4(float asdw, float directionasdw)
    {
        asdweda = GetComponent<Swim>();
        asdweda.Spsdfeeed = ((Mathf.PI * asdw) / 5);
        asdweda.RotaxcveteSpeed = 38;
        this.asdw = new List<Transform>();
        for (int i = 0; i < coxcveduntFish; i++)
        {
            Transform _tr = Instantiate(_FishxcvdPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Distazxdcfen * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SetTargedfgrt(transform, Vector3.Magnitude(transform.right * Distazxdcfen * i));
            _tr.GetComponent<Swim>().Spsdfeeed = asdweda.Spsdfeeed;
            _tr.GetComponent<Swim>().RotaxcveteSpeed = 38;
            if (directionasdw == 0)
                _tr.gameObject.AddComponent<SwinRotationBonus>().asdqwervfc = 270;
            else
                _tr.gameObject.AddComponent<SwinRotationBonus>().asdqwervfc = 90;
            this.asdw.Add(_tr);
        }
        Destroy(gameObject);
    }

    void Update()
    {
        // transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, 270), 180 * Time.deltaTime / 5);
    }

    public void destroasdwyOnList(Transform _trs)
    {
        asdw.Remove(_trs);

        if (asdw.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
