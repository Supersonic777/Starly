using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipSpawner : MonoBehaviour
{
    public float timeToSpawn;
    public Transform[] spawnersList;
    public GameObject[] spaceshipList;
    private int spaceshipListLength;
    private int spawnersListLength;
    // Start is called before the first frame update
    void Start()
    {
        spaceshipListLength = spaceshipList.Length;
        spawnersListLength = spawnersList.Length;
        StartCoroutine(SpawnGO());
    }

    void Repeat()
    {
        StartCoroutine(SpawnGO());
    }
    IEnumerator SpawnGO()
    {
        yield return new WaitForSeconds(timeToSpawn += Random.Range(-5,10));
        Instantiate(spaceshipList[Random.Range(0,spaceshipListLength-1)], spawnersList[Random.Range(0,spawnersListLength-1)].position, Quaternion.identity);
        Repeat();
    }
}