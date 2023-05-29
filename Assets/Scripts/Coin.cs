using UnityEngine;

public class Coin : MonoBehaviour 
{
    public Rigidbody rb;
    public float speed;
    public int value;

    void Start()
    {
        rb.velocity = Vector3.down * speed;
    }

        private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Despawn")) {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player")){
            //Play destroy animation
            Destroy(gameObject);
        }
    }
}