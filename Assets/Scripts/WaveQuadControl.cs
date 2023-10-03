using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WaveQuadControl : MonoBehaviour
{

    void Stsart()
    {
        rasdqn = GetComponent<MeshRenderer>();
        rasdqn.material.mainTextureOffset = new Vector2(0, 0);
        rasdqn.sortingOrder = 1;
        rasdqn.sortingLayerName = "bg";
    }

    void Upqdate()
    {
        rasdqn.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * speeasdqd / 20, 1), 0);
    }
    [FormerlySerializedAs("speed")] public float speeasdqd;
    Renderer rasdqn;

    void Start()
    {
        rasdqn = GetComponent<MeshRenderer>();
        rasdqn.material.mainTextureOffset = new Vector2(0, 0);
        rasdqn.sortingOrder = 1;
        rasdqn.sortingLayerName = "bg";
    }

    void Update()
    {
        rasdqn.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * speeasdqd / 20, 1), 0);
    }
}
