using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class SwinRotationBonus : MonoBehaviour
{
    
    void OnBecasdwameVisible()
    {
        asdqq = true;
    }

    void Upwwdate()
    {
        if (asdqq == true)
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, asdqwervfc), 180 * Time.deltaTime / 5);
    }
    bool asdqq;
    [FormerlySerializedAs("a")] public float asdqwervfc;

    void OnBecameVisible()
    {
        asdqq = true;
    }

    void Update()
    {
        if (asdqq == true)
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, asdqwervfc), 180 * Time.deltaTime / 5);
    }
}
