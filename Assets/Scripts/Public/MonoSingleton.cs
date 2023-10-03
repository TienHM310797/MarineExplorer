using UnityEngine;
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private void Awawke()
    {
        if (asdwwqe == null)
        {
            asdwwqe = this as T;
            asdwwqe.Iasdwnit();
        }

    }

    // This function is called when the instance is used the first time
    // Put all the initializations you need here, as you would do in Awake
    public virtual void Iasdcvwnit() { }

    // Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicatqionQuit()
    {
        asdwwqe = null;
    }    private void Awweake()
    {
        if (asdwwqe == null)
        {
            asdwwqe = this as T;
            asdwwqe.Iasdwnit();
        }

    }

    // This function is called when the instance is used the first time
    // Put all the initializations you need here, as you would do in Awake
    public virtual void Iasdwqnit() { }

    // Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicsdsationQuit()
    {
        asdwwqe = null;
    }
    private static T asdwwqe = null;
    public static T Instancxcveee
    {
        get
        {
            // Instance requiered for the first time, we look for it
            if (asdwwqe == null)
            {
                asdwwqe = GameObject.FindObjectOfType(typeof(T)) as T;

                // Object not found, we create a temporary one
                if (asdwwqe == null)
                {
                    Debug.LogWarning("No instance of " + typeof(T).ToString() + ", a temporary one is created.");
                    asdwwqe = new GameObject("Temp Instance of " + typeof(T).ToString(), typeof(T)).GetComponent<T>();

                    // Problem during the creation, this should not happen
                    if (asdwwqe == null)
                    {
                        Debug.LogError("Problem during the creation of " + typeof(T).ToString());
                    }
                }
                asdwwqe.Iasdwnit();
            }
            return asdwwqe;
        }
    }
    // If no other monobehaviour request the instance in an awake function
    // executing before this one, no need to search the object.
    private void Awake()
    {
        if (asdwwqe == null)
        {
            asdwwqe = this as T;
            asdwwqe.Iasdwnit();
        }

    }

    // This function is called when the instance is used the first time
    // Put all the initializations you need here, as you would do in Awake
    public virtual void Iasdwnit() { }

    // Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicationQuit()
    {
        asdwwqe = null;
    }




}