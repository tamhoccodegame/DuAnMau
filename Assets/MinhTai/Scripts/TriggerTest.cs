using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerTest: OnTriggerEnter called with " + other.name);
    }
}
