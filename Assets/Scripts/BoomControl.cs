using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class BoomControl : MonoBehaviour
{    void Updaasdte()
    {
        _poasdwsMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(_poasdwsMouse.x, _poasdwsMouse.y, -6);

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(transform.position.x, transform.position.y, 0), 2, Vector3.zero);
            AudioControl.Instasdqance.booasdqm();
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i].collider.tag == "fish")
                    fish[i].collider.gameObject.GetComponent<FishControl>().hitDsdwwame(1000, gameObject);
            }
            GameObject boom = (GameObject)Instantiate(easdwff, transform.position, Quaternion.identity);
            Destroy(boom, 1.5f);
            Destroy(gameObject);
        }
    }    void Upssdate()
    {
        _poasdwsMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(_poasdwsMouse.x, _poasdwsMouse.y, -6);

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(transform.position.x, transform.position.y, 0), 2, Vector3.zero);
            AudioControl.Instasdqance.booasdqm();
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i].collider.tag == "fish")
                    fish[i].collider.gameObject.GetComponent<FishControl>().hitDsdwwame(1000, gameObject);
            }
            GameObject boom = (GameObject)Instantiate(easdwff, transform.position, Quaternion.identity);
            Destroy(boom, 1.5f);
            Destroy(gameObject);
        }
    }
    [FormerlySerializedAs("eff")] public GameObject easdwff;
    Vector3 _poasdwsMouse;
    void Update()
    {
        _poasdwsMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(_poasdwsMouse.x, _poasdwsMouse.y, -6);

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(transform.position.x, transform.position.y, 0), 2, Vector3.zero);
            AudioControl.Instasdqance.booasdqm();
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i].collider.tag == "fish")
                    fish[i].collider.gameObject.GetComponent<FishControl>().hitDsdwwame(1000, gameObject);
            }
            GameObject boom = (GameObject)Instantiate(easdwff, transform.position, Quaternion.identity);
            Destroy(boom, 1.5f);
            Destroy(gameObject);
        }
    }
}
