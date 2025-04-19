using UnityEngine;

public class Spin : MonoBehaviour
{
    public bool isRandomDirection = false;
    public Vector3 rotationSpeed = new Vector3(200f,0f,0f);
    public float direction { get; set; }
    void Start()
    {
        if (isRandomDirection) {
            direction = Random.Range(0,2) == 0 ? 1 : -1; 
        }
    }
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime * direction);
    }
}
