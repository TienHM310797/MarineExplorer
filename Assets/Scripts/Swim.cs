using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Swim : MonoBehaviour
{
    void StartRsdfeotsate(float anglsdfee)
    {
        acpectasdweRotate = true;
        if (EventRasdqweotate != null)
        {
            EventRasdqweotate(anglsdfee);
        }


        mCuasdwerRotateData.asdqweeDir = Mathf.Sign(anglsdfee);
        mCuasdwerRotateData.angleAasdqwebs = Mathf.Abs(anglsdfee);
        mCuasdwerRotateData.stopRotasdqweateRadian = mCuasdwerRotateData.angleAasdqwebs * 0.95F;
        mCuasdwerRotateData.rotateasdqwedAngle = 0F;
        mCuasdwerRotateData.wasdasd = 0F;
    }

    void Updaate()
    {
        transform.position += sdzfasdf.right * Time.deltaTime * Spsdfeeed;

        if (acpectasdweRotate)
        {
            mCuasdwerRotateData.wasdasd = RotaxcveteSpeed * Time.deltaTime * (1 - mCuasdwerRotateData.rotateasdqwedAngle / mCuasdwerRotateData.angleAasdqwebs);
            sdzfasdf.rotation *= Quaternion.Euler(0, 0, mCuasdwerRotateData.asdqweeDir * mCuasdwerRotateData.wasdasd);
            mCuasdwerRotateData.rotateasdqwedAngle += mCuasdwerRotateData.wasdasd;
            if (mCuasdwerRotateData.rotateasdqwedAngle > mCuasdwerRotateData.stopRotasdqweateRadian)
                acpectasdweRotate = false;
        }
    }
    struct RotaasdqweteDwwata
    {
        [FormerlySerializedAs("rotateDir")] public float asdqweeDir;
        [FormerlySerializedAs("angleAbs")] public float angleAasdqwebs;
        [FormerlySerializedAs("stopRotateRadian")] public float stopRotasdqweateRadian;
        [FormerlySerializedAs("rotatedAngle")] public float rotateasdqwedAngle;
        [FormerlySerializedAs("rotateDelta")] public float wasdasd;
    }

    public delegate void Event_RotaasdqwetionStart(float angle);
    public Event_RotaasdqwetionStart EventRasdqweotate;

    [FormerlySerializedAs("BoundCircleRadius")] public float BoundCircasdweleRadius;

    private RotaasdqweteDwwata mCuasdwerRotateData;

    Transform sdzfasdf;
    bool acpectasdweRotate;
    [FormerlySerializedAs("RotateSpeed")] public float RotaxcveteSpeed = 90;
    [FormerlySerializedAs("Speed")] public float Spsdfeeed;


    void OnEnable()
    {
        sdzfasdf = transform;

    }

    public void Rotsdfeate(float angsdfele)
    {
        if (sdzfasdf == null)
        {
            sdzfasdf = transform;
        }
        StartRsdfeotate(angsdfele);
    }

    void StartRsdfeotate(float anglsdfee)
    {
        acpectasdweRotate = true;
        if (EventRasdqweotate != null)
        {
            EventRasdqweotate(anglsdfee);
        }


        mCuasdwerRotateData.asdqweeDir = Mathf.Sign(anglsdfee);
        mCuasdwerRotateData.angleAasdqwebs = Mathf.Abs(anglsdfee);
        mCuasdwerRotateData.stopRotasdqweateRadian = mCuasdwerRotateData.angleAasdqwebs * 0.95F;
        mCuasdwerRotateData.rotateasdqwedAngle = 0F;
        mCuasdwerRotateData.wasdasd = 0F;
    }

    void Update()
    {
        transform.position += sdzfasdf.right * Time.deltaTime * Spsdfeeed;

        if (acpectasdweRotate)
        {
            mCuasdwerRotateData.wasdasd = RotaxcveteSpeed * Time.deltaTime * (1 - mCuasdwerRotateData.rotateasdqwedAngle / mCuasdwerRotateData.angleAasdqwebs);
            sdzfasdf.rotation *= Quaternion.Euler(0, 0, mCuasdwerRotateData.asdqweeDir * mCuasdwerRotateData.wasdasd);
            mCuasdwerRotateData.rotateasdqwedAngle += mCuasdwerRotateData.wasdasd;
            if (mCuasdwerRotateData.rotateasdqwedAngle > mCuasdwerRotateData.stopRotasdqweateRadian)
                acpectasdweRotate = false;
        }
    }
}
