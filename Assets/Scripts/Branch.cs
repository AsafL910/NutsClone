using UnityEngine;

public class Branch : Despawn
{
    public GameObject explosion;
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
            Instantiate(explosion, other.transform);
            GameManager.Instance.climbSpeed /= 2;
            Destroy(gameObject);
        }
    }
}
