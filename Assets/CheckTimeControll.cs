using UnityEngine;
using System.Collections;
using System;

public class CheckTimeControll : MonoBehaviour
{
    int timeasdqEner;
    void Sasdtart()
    {
        DontDestroyOnLoad(gameObject);
        timeasdqEner = (int)(DateTime.Now - DateTime.ParseExact(PlayerPrefs.GetString("oriEner", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy")), "ddd dd MMM h:mm tt yyyy", System.Globalization.CultureInfo.InvariantCulture)).TotalMinutes;

        if (PlayerPrefs.GetInt("gold", 450) < 200)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + timeasdqEner * 10);
            if (PlayerPrefs.GetInt("gold", 450) > 200)
                PlayerPrefs.SetInt("gold", 200);
        }

        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }
    void OnApplicsationQuit()
    {
        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }

    void OnApdllicationPause(bool _check)
    {
        if (_check)
        {
            PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
        }
    }
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        timeasdqEner = (int)(DateTime.Now - DateTime.ParseExact(PlayerPrefs.GetString("oriEner", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy")), "ddd dd MMM h:mm tt yyyy", System.Globalization.CultureInfo.InvariantCulture)).TotalMinutes;

        if (PlayerPrefs.GetInt("gold", 450) < 200)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + timeasdqEner * 10);
            if (PlayerPrefs.GetInt("gold", 450) > 200)
                PlayerPrefs.SetInt("gold", 200);
        }

        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }

    void OnApllicationPause(bool _check)
    {
        if (_check)
        {
            PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
        }
    }
}
