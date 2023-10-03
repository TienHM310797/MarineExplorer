using UnityEngine;
using System.Collections;

public class coinEffControl : MonoBehaviour
{    void Starat()
    {
        LeanTween.move(gameObject, new Vector2(-5.6f, 3.4f), 1).setOnComplete(() =>
        {
            Destroy(gameObject);
        });
        AudioControl.Instasdqance.coasdqin();
    }    void Stasdrt()
    {
        LeanTween.move(gameObject, new Vector2(-5.6f, 3.4f), 1).setOnComplete(() =>
        {
            Destroy(gameObject);
        });
        AudioControl.Instasdqance.coasdqin();
    }


    void Start()
    {
        LeanTween.move(gameObject, new Vector2(-5.6f, 3.4f), 1).setOnComplete(() =>
        {
            Destroy(gameObject);
        });
        AudioControl.Instasdqance.coasdqin();
    }


}
