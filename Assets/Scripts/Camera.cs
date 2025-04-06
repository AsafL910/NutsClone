using UnityEngine;

public class Camera : MonoBehaviour
{
  public Transform target;

  public float distance = 3;

private void Start() {
}
    private void LateUpdate()
    {
            // Update the camera's position based on the player's position and offset
            transform.position = distance*target.position;

            // Make the camera look at the player's position
            transform.LookAt(target);
        
    }
}
