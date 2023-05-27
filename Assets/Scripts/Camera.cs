using UnityEngine;

public class Camera : MonoBehaviour
{
  public Transform target;

private void Start() {
}
    private void LateUpdate()
    {
            // Update the camera's position based on the player's position and offset
            transform.position = 3*target.position;

            // Make the camera look at the player's position
            transform.LookAt(target);
        
    }
}
