using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotSpod = 100.0f;
    void Update()
    {
        transform.Rotate(0f, 0f, rotSpod*Time.deltaTime);
    }
}
