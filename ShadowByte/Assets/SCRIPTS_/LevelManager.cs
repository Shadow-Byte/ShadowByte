using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    void Start()
    {
        SpawnNewObject();
    }

    // drop your spawn points in this array in the inspector
    public Transform[] possibleSpawnPositions;

    // drop a gameObject (preferably a prefab) here in the inspector
    public GameObject objectTypeToSpawn;

    // call this function whenever you want to spawn a new object at a random position
    public void SpawnNewObject()
    {
        Transform spawnPointReference = GetSpawnPointReference();
        Transform newObject = Instantiate(objectTypeToSpawn, spawnPointReference.position, spawnPointReference.rotation) as Transform;

        // do any other stuff with newObject here...
    }

    // function to get a random transform from the list of possible spawn points
    public Transform GetSpawnPointReference()
    {
        int randomIndex = Random.Range(0, possibleSpawnPositions.Length);
        return possibleSpawnPositions[randomIndex];
    }

}
