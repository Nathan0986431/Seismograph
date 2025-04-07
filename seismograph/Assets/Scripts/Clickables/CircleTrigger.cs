using UnityEngine;

public class CircleTrigger : MonoBehaviour
{
    private GameObject pingClone; // Reference to the Ping clone that the Crosshair can destroy

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the Crosshair enters the trigger zone
        if (other.CompareTag("Crosshair"))
        {
            // Find the nearest Ping clone in the trigger zone (can modify to select specific Ping clones if needed)
            pingClone = GameObject.FindWithTag("Ping");
            Debug.Log("Ping clone assigned: " + pingClone?.name);
        }
    }

    private void Update()
    {
        // If the Crosshair is in the trigger zone and spacebar is pressed
        if (pingClone != null && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Destroying Ping clone: " + pingClone.name);
            Destroy(pingClone); // Destroy the Ping clone
            pingClone = null; // Reset reference after destruction
        }
    }
}