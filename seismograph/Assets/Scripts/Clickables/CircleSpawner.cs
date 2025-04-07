using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject pingPrefab; // The Ping prefab to spawn
    public float spawnInterval = 2f; // How often to spawn Ping clones
    public float spawnRadius = 5f; // How far from the spawner the Ping clones can spawn

    private void Start()
    {
        // Start spawning Ping clones at regular intervals
        InvokeRepeating("SpawnPing", 0f, spawnInterval);
    }

    void SpawnPing()
    {
        // Random position within the spawn radius
        Vector2 randomPosition = (Vector2)transform.position + Random.insideUnitCircle * spawnRadius;
        Instantiate(pingPrefab, randomPosition, Quaternion.identity); // Instantiate the Ping prefab
    }
}