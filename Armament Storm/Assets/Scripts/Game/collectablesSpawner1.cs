using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectablesSpawner1 : MonoBehaviour
{
    [SerializeField] private float spawnRate = 2f;
    [SerializeField] private GameObject collectablesPrefabs;
    public bool canSpawn = true;

    private void Start()
    {
        StartNewCoroutine();
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        yield return wait;
        Instantiate(collectablesPrefabs, transform.position, Quaternion.identity);
    }

    public void StartNewCoroutine()
    {
        StartCoroutine(Spawner());
    }
}
