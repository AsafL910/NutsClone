using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(200f,0f,0f);

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
