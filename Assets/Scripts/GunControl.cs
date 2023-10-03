using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class GunControl : MonoBehaviour
{
    public void ChangtoRsasdweocket()
    {
        _checasdwkfire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _checasdwkfire = true;
            _tenluasdwa = true;
        });
        teasdwnlua.SetActive(true);
        teasdwnlua.transform.localScale = Vector3.zero;
        teasdwnlua.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        teasdwnlua.transform.up = Vector3.up;
        LeanTween.scale(teasdwnlua, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }    public void ChangtoRasadweocket()
    {
        _checasdwkfire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _checasdwkfire = true;
            _tenluasdwa = true;
        });
        teasdwnlua.SetActive(true);
        teasdwnlua.transform.localScale = Vector3.zero;
        teasdwnlua.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        teasdwnlua.transform.up = Vector3.up;
        LeanTween.scale(teasdwnlua, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }
    public static GunControl asdqwe;
    [FormerlySerializedAs("Bullet")] public GameObject Bullasdqwet;
    public static int wwBonusCoinasdqwe;
    [FormerlySerializedAs("tenlua")] public GameObject teasdwnlua;
    [FormerlySerializedAs("_effboom")] public GameObject _effasdweboom;
    

    bool _checasdwkfire;
    bool _tenluasdwa;
    Animator _awewwniasd;
    int asedw_levewelGun;

    void Start()
    {
        _checasdwkfire = true;
        _tenluasdwa = false;
        asdqwe = this;
        _awewwniasd = GetComponent<Animator>();
        _awewwniasd.Play("Idle", 0, 0);
        _awewwniasd.SetFloat("level", 0);
        _awewwniasd.speed = 2;
        asedw_levewelGun = 1;
        wwBonusCoinasdqwe = 1;
    }


    public void PlusGunasdqw()
    {
        if (!_checasdwkfire) return;
        if (asedw_levewelGun < 9)
            asedw_levewelGun += 1;
        else
            asedw_levewelGun = 1;

        _awewwniasd.SetFloat("level", asedw_levewelGun);
    }

    public void MinusGunasdq()
    {
        if (!_checasdwkfire) return;
        if (asedw_levewelGun > 1)
            asedw_levewelGun -= 1;
        else
            asedw_levewelGun = 9;

        _awewwniasd.SetFloat("level", asedw_levewelGun);
    }

    public void Fireasdw()
    {
		
        Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = Vector3.Normalize(mousePoint + Vector3.forward * 10 - transform.position);
		if (PlayerPrefs.GetInt("gold", 450) < asedw_levewelGun && _tenluasdwa == false){
			UIManager.Instancxcveee.EnablePopUasdqpCoin();
		}
        else
        {
            if (PlayerPrefs.GetInt("gold", 450) >= asedw_levewelGun && _checasdwkfire && _tenluasdwa == false)
            {
                _awewwniasd.Play("Fire", 0, 0);
                AudioControl.Instasdqance.shasdqoot();
                GameObject _bullet = (GameObject)Instantiate(Bullasdqwet);
                _bullet.transform.position = transform.position + transform.up * 0.5f;
                _bullet.GetComponent<BulletControl>().InitBsdfeullet(asedw_levewelGun, transform, new Vector2(mousePoint.x, mousePoint.y));

                UiTextSpawmControl.Instasdqance.MiasdqnusGold(asedw_levewelGun);
            }
        }
        if (_tenluasdwa && _checasdwkfire)
        {
            _tenluasdwa = false;
            teasdwnlua.transform.up = Vector3.Normalize(mousePoint + Vector3.forward * 10 - teasdwnlua.transform.position);
            _checasdwkfire = false;
            LeanTween.move(teasdwnlua, new Vector3(mousePoint.x, mousePoint.y, 0), 0.2f * (Vector2.Distance(mousePoint, teasdwnlua.transform.position))).setOnComplete(() =>
            {
                RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(teasdwnlua.transform.position.x, teasdwnlua.transform.position.y, 0), 2, Vector3.zero);
                AudioControl.Instasdqance.booasdqm();
                for (int i = 0; i < fish.Length; i++)
                {
                    if (fish[i].collider.tag == "fish")
                        fish[i].collider.gameObject.GetComponent<FishControl>().hitDsdwwame(1000, gameObject);
                }
                GameObject boom = (GameObject)Instantiate(_effasdweboom, teasdwnlua.transform.position + teasdwnlua.transform.up * 0.5f, Quaternion.identity);
                Destroy(boom, 1.5f);
                teasdwnlua.SetActive(false);
                GetComponent<SpriteRenderer>().enabled = true;
                transform.up = Vector3.up;
                transform.localScale = Vector3.zero;
                LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack).setOnComplete(() =>
                {
                    _checasdwkfire = true;
                });
            });
        }
    }

    public void ChangtoRasdweocket()
    {
        _checasdwkfire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _checasdwkfire = true;
            _tenluasdwa = true;
        });
        teasdwnlua.SetActive(true);
        teasdwnlua.transform.localScale = Vector3.zero;
        teasdwnlua.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        teasdwnlua.transform.up = Vector3.up;
        LeanTween.scale(teasdwnlua, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }

}
