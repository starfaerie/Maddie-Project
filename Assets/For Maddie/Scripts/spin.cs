using UnityEngine;

[ExecuteAlways]
public class spin : MonoBehaviour
{
    [Range(0.2f, 10f)]
    public float rotationSpeed = 2f;

    [Range(-180f, 180f)] public float rotationX, rotationY, rotationZ;
    void Update()
    {
        transform.Rotate(rotationX * (rotationSpeed * Time.deltaTime), rotationY * (rotationSpeed * Time.deltaTime),rotationZ * (rotationSpeed * Time.deltaTime), Space.Self);
    }
}