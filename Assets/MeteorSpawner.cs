using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public float timeToSpawn;
    public Transform[] spawnersList;
    public GameObject[] meteorsList;
    private int meteorsListLenhth;
    private int spawnersListLenhth;
    // Start is called before the first frame update
    void Start()
    {
        meteorsListLenhth = meteorsList.Length;
        spawnersListLenhth = spawnersList.Length;
        StartCoroutine(SpawnGO());
    }

    void Repeat()
    {
        StartCoroutine(SpawnGO());
    }
    IEnumerator SpawnGO()
    {
        yield return new WaitForSeconds(timeToSpawn += Random.Range(0,1));
        Instantiate(meteorsList[Random.Range(0,meteorsListLenhth-1)], spawnersList[Random.Range(0,spawnersListLenhth-1)].position, Quaternion.identity);
        Repeat();
    }
}
