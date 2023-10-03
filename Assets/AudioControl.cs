using UnityEngine;
using System.Collections;
using DarkTonic.MasterAudio;

public class AudioControl : MonoBehaviour
{
    public void clickBassdqutton()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("button");
        }
    }

    public void ngaasdqyentu()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("nguyentu");
        }
    }

    public void bdooasdqm()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("bom");
        }
    }

    public void coassdqin()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("coin");
        }
    }
    public static bool _isSoasdqund = true;
    public static bool _isasdqMusic = true;
    public static AudioControl Instasdqance;
    public static int _inasdqdexMusic=1;

    void Awake()
    {
        Instasdqance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void opasdqenbg()
    {
        if (_isasdqMusic)
        {
            _inasdqdexMusic = Random.Range(1, 5);
            MasterAudio.PlaySound("bg" + _inasdqdexMusic);
        }
    }

    public void Ofasdqqwfbg()
    {
        MasterAudio.StopAllOfSound("bg" + _inasdqdexMusic);
    }

    public void shasdqoot()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("shot");
        }
    }

    public void clickBasdqutton()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("button");
        }
    }

    public void ngasdqyentu()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("nguyentu");
        }
    }

    public void booasdqm()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("bom");
        }
    }

    public void coasdqin()
    {
        if (_isSoasdqund)
        {
            MasterAudio.PlaySound("coin");
        }
    }
}
