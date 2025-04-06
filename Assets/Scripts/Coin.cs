using UnityEngine;

public class Coin : MonoBehaviour
{
    public Rigidbody rb;

    public int value;

    void Start()
    {
        // rb.velocity = Vector3.down * speed;
    }


    void Update()
    {
        rb.velocity = Vector3.down * GameManager.Instance.climbSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Despawn"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            //Play destroy animation
            Destroy(gameObject);
        }
    }
}