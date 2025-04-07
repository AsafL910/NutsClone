using UnityEngine;

public class Branch : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
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
            GameManager.Instance.climbSpeed /= 2;
            Destroy(gameObject);
        }
    }
}
