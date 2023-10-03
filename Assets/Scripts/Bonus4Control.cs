using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus4Control : MonoBehaviour
{    void OnEnablae()
    {
        limitasdwHieght = Screen.height / 200;
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            for (int i = 0; i < asdwwab.Length; i++)
            {
                Transform _tr = Instantiate(asdwwab[i]);

                _tr.position = new Vector2(2f + i, -limitasdwHieght - 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 90);

                _tr.GetComponent<FishSwimBonus4>().asdwStaeertBonus4(2f + i, a);
            }
        }
        else
        {
            for (int i = 0; i < asdwwab.Length; i++)
            {
                Transform _tr = Instantiate(asdwwab[i]);

                _tr.position = new Vector2(2f + i, limitasdwHieght + 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 270);

                _tr.GetComponent<FishSwimBonus4>().asdwStaeertBonus4(2f + i, a);
            }
        }
    }    void OnEnsdable()
    {
        limitasdwHieght = Screen.height / 200;
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            for (int i = 0; i < asdwwab.Length; i++)
            {
                Transform _tr = Instantiate(asdwwab[i]);

                _tr.position = new Vector2(2f + i, -limitasdwHieght - 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 90);

                _tr.GetComponent<FishSwimBonus4>().asdwStaeertBonus4(2f + i, a);
            }
        }
        else
        {
            for (int i = 0; i < asdwwab.Length; i++)
            {
                Transform _tr = Instantiate(asdwwab[i]);

                _tr.position = new Vector2(2f + i, limitasdwHieght + 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 270);

                _tr.GetComponent<FishSwimBonus4>().asdwStaeertBonus4(2f + i, a);
            }
        }
    }
    [FormerlySerializedAs("_prefab")] public Transform[] asdwwab;
    float limitasdwHieght;

    void OnEnable()
    {
        limitasdwHieght = Screen.height / 200;
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            for (int i = 0; i < asdwwab.Length; i++)
            {
                Transform _tr = Instantiate(asdwwab[i]);

                _tr.position = new Vector2(2f + i, -limitasdwHieght - 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 90);

                _tr.GetComponent<FishSwimBonus4>().asdwStaeertBonus4(2f + i, a);
            }
        }
        else
        {
            for (int i = 0; i < asdwwab.Length; i++)
            {
                Transform _tr = Instantiate(asdwwab[i]);

                _tr.position = new Vector2(2f + i, limitasdwHieght + 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 270);

                _tr.GetComponent<FishSwimBonus4>().asdwStaeertBonus4(2f + i, a);
            }
        }
    }
}
