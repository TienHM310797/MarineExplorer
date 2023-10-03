using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WaveControl : MonoBehaviour {
    
    void Updasdqate () {
        transform.Translate(Vector3.left * spsdfweed * Time.smoothDeltaTime);
    }

    void OnBecameasdqInvisible()
    {
        FishManage.Instasdfence.BosdfefsTime();
        gameObject.SetActive(false);
    }

    void OnTriqweggerEntqweer2D(Collider2D col)
    {
        if (col.tag == "fish")
        {
            col.GetComponent<FishControl>().ColasdwwlisionWithWave();
        }
    }
    [FormerlySerializedAs("speed")] public float spsdfweed = 2;

	void Update () {
        transform.Translate(Vector3.left * spsdfweed * Time.smoothDeltaTime);
	}

    void OnBecameInvisible()
    {
        FishManage.Instasdfence.BosdfefsTime();
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "fish")
        {
            col.GetComponent<FishControl>().ColasdwwlisionWithWave();
        }
    }
}
