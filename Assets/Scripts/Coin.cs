using UnityEngine;

public class Coin : MonoBehaviour
{
    public Rigidbody rb;

    public int value;

    void Update()
    {
        rb.velocity = Vector3.down * GameManager.Instance.climbSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Despawn") || other.CompareTag("Branch"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.totalCoins += value;
            Destroy(gameObject);
        }
    }
}