using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class BulletControl : MonoBehaviour
{
    void Aswake()
    {
        _spsdferite = GetComponent<SpriteRenderer>();
    }


    [FormerlySerializedAs("ListBullet")] public Sprite[] asdw;
    [FormerlySerializedAs("speed")] public float xcvd;
    [FormerlySerializedAs("_web")] public GameObject sdfwer;

    SpriteRenderer _spsdferite;


    void Awake()
    {
        _spsdferite = GetComponent<SpriteRenderer>();
    }

    public void InitBsdfeullet(int levdfeel, Transform Gunsdfe, Vector2 target)
    {
        _spsdferite.sprite = asdw[levdfeel - 1];
        transform.up = Gunsdfe.up;
        LeanTween.move(gameObject, target, xcvd * (Vector2.Distance(target, transform.position))).setOnComplete(() =>
        {
            GameObject web = (GameObject)Instantiate(sdfwer);
            web.transform.position = transform.position;
            web.transform.up = transform.up;
            web.GetComponent<WebControl>().InieetWebsdfwer(levdfeel);
            Destroy(gameObject);
        });
    }
}