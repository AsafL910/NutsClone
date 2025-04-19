using UnityEngine;

public class Branch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.down * GameManager.Instance.climbSpeed * Time.deltaTime;
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
