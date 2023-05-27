using UnityEngine;

public class Branch : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0,Random.Range(0,360),90);
        rb.velocity = Vector3.down * speed;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Despawn")) {
            Destroy(gameObject);
        }
    }
}
