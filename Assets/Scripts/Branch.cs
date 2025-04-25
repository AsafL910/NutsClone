using UnityEngine;

public class Branch : Despawn
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.down * GameManager.Instance.climbSpeed * Time.deltaTime;
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        
        if (other.CompareTag("Player"))
        {
            //Play destroy animation
            GameManager.Instance.climbSpeed /= 2;
            Destroy(gameObject);
        }
    }
}
