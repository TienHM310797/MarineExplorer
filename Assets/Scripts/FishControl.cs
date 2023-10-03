using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishControl : MonoBehaviour
{
    public void ColasdwwlisdwsionWithWave()
    {
        if (_asdwcallDie != null)
        {
            _asdwcallDie();
        }
        FishManage.Instasdfence._FishMasdfenge.Remove(transform);
        Destroy(gameObject);


    }


    void OnBecamessVisible()
    {
        if (gameObject.tag == "fish")
        {
            if (_checasdwwwkInvisible) return;
            _checasdwwwkInvisible = true;
            FishManage.Instasdfence._FishMasdfenge.Add(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Instasdfence._CasdfeMapManage.Add(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Instasdfence._MucMasdfenager.Add(transform);
                }
            }
        }
    }

    void OnDasdestroy()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Instasdfence._FishMasdfenge.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Instasdfence._CasdfeMapManage.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Instasdfence._MucMasdfenager.Remove(transform);
                }
            }
        }
    }

    void OnBecameInvsisible()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Instasdfence._FishMasdfenge.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Instasdfence._CasdfeMapManage.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Instasdfence._MucMasdfenager.Remove(transform);
                }
            }
        }
        Destroy(gameObject);

    }
    [FormerlySerializedAs("AnimationName")] public string asdwwAnimwwwwationName;
    [FormerlySerializedAs("AnimationNameDie")] public string asdwdfvfds;
    Animator asdww;

    [FormerlySerializedAs("Hp")] public int asdwww;
    [FormerlySerializedAs("RndHp")] public int RndHxcveep;

    [FormerlySerializedAs("HpMax")] public int HpMzscesdax;
    [FormerlySerializedAs("RndHpMax")] public int RndsdfeeeHpMax;

    Swim _asdwswim;
    int aawedasdfc;
    GameObject _checkCollsasdwwion;

    bool _checasdwwwkInvisible;

    public delegate void CallDieasdww();
    public CallDieasdww _asdwcallDie;

    [FormerlySerializedAs("_gold")] public int _gsdwold;

    void OnEnable()
    {
        _checasdwwwkInvisible = false;
        asdww = GetComponent<Animator>();
        asdww.Play(asdwwAnimwwwwationName, 0, Random.Range(0f, 1f));

        _asdwswim = GetComponent<Swim>();

        if (Random.Range(0, 2) == 1)
            aawedasdfc = Random.Range(HpMzscesdax - RndsdfeeeHpMax, HpMzscesdax + RndsdfeeeHpMax);
        else
            aawedasdfc = Random.Range(asdwww - RndHxcveep, asdwww - RndHxcveep);
    }

    public void hitDsdwwame(int dame, GameObject obj)
    {
        if (_checkCollsasdwwion == null || (_checkCollsasdwwion.GetInstanceID() != obj.GetInstanceID()))
        {
            aawedasdfc -= dame;
            _checkCollsasdwwion = obj;

            if (aawedasdfc <= 0)
            {
                if (_asdwcallDie != null)
                {
                    _asdwcallDie();
                }
                _asdwswim.enabled = false;
                asdww.Play(asdwdfvfds, 0, 0);
                GetComponent<BoxCollider2D>().enabled = false;
                Instantiate(Resources.Load("coinEff"), transform.position + Vector3.up * 0.5f, Quaternion.identity);
                UiTextSpawmControl.Instasdqance.CallTeasdqxtEff(transform.position + Vector3.up * 0.5f, _gsdwold);
                FishManage.Instasdfence._FishMasdfenge.Remove(transform);
                Destroy(gameObject, 0.8f);
            }
        }
    }

    public void ColasdwwlisionWithWave()
    {
        if (_asdwcallDie != null)
        {
            _asdwcallDie();
        }
        FishManage.Instasdfence._FishMasdfenge.Remove(transform);
        Destroy(gameObject);


    }


    void OnBecameVisible()
    {
        if (gameObject.tag == "fish")
        {
            if (_checasdwwwkInvisible) return;
            _checasdwwwkInvisible = true;
            FishManage.Instasdfence._FishMasdfenge.Add(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Instasdfence._CasdfeMapManage.Add(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Instasdfence._MucMasdfenager.Add(transform);
                }
            }
        }
    }

    void OnDestroy()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Instasdfence._FishMasdfenge.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Instasdfence._CasdfeMapManage.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Instasdfence._MucMasdfenager.Remove(transform);
                }
            }
        }
    }

    void OnBecameInvisible()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Instasdfence._FishMasdfenge.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Instasdfence._CasdfeMapManage.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Instasdfence._MucMasdfenager.Remove(transform);
                }
            }
        }
        Destroy(gameObject);

    }
}
