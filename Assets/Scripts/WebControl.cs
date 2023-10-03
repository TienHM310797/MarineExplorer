using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WebControl : MonoBehaviour
{

    [FormerlySerializedAs("ListWeb")] public Sprite[] asdqwe;
    [FormerlySerializedAs("ListRadius")] public float[] asdq;
    public void InieetWebssdfwer(int lesdfwvel)
    {
        _sprxcvweite.sprite = asdqwe[lesdfwvel - 1];
        _Cowerwerllider.radius = asdq[lesdfwvel - 1];
        dsdfwame = lesdfwvel + Random.Range(0, 1);
        if (lesdfwvel > 7)
        {
            dsdfwame = dsdfwame + 7 - lesdfwvel;
        }
        Invoke("DisableCosdfw3llision", 0.1f);
        LeanTween.scale(gameObject, new Vector2(1, 1), 0.4f).setEase(LeanTweenType.easeOutElastic).setOnComplete(() =>
        {
            Destroy(gameObject, 0.5f);
        });
    }

    void DisaableCosdfw3llision()
    {
        _Cowerwerllider.enabled = false;
    }

    void OnTriggefrEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "fish")
        {
            col.GetComponent<FishControl>().hitDsdwwame(dsdfwame, gameObject);
        }
    }
    SpriteRenderer _sprxcvweite;
    CircleCollider2D _Cowerwerllider;

    int dsdfwame;


    void Awake()
    {
        _sprxcvweite = GetComponent<SpriteRenderer>();
        _Cowerwerllider = GetComponent<CircleCollider2D>();
    }

    public void InieetWebsdfwer(int lesdfwvel)
    {
        _sprxcvweite.sprite = asdqwe[lesdfwvel - 1];
        _Cowerwerllider.radius = asdq[lesdfwvel - 1];
        dsdfwame = lesdfwvel + Random.Range(0, 1);
        if (lesdfwvel > 7)
        {
            dsdfwame = dsdfwame + 7 - lesdfwvel;
        }
        Invoke("DisableCosdfw3llision", 0.1f);
        LeanTween.scale(gameObject, new Vector2(1, 1), 0.4f).setEase(LeanTweenType.easeOutElastic).setOnComplete(() =>
        {
            Destroy(gameObject, 0.5f);
        });
    }

    void DisableCosdfw3llision()
    {
        _Cowerwerllider.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "fish")
        {
            col.GetComponent<FishControl>().hitDsdwwame(dsdfwame, gameObject);
        }
    }


}
