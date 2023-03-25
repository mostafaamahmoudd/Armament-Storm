using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectablesSpawner1 : MonoBehaviour
{
    [SerializeField] private float spawnRate = 2f;

    [SerializeField] private GameObject collectablesPrefabs;
    [SerializeField] private GameObject[] gameObjects;

    public bool canSpawn = true;

    private void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            StartNewCoroutine((Vector3) gameObjects[i].transform.position);
        }
    }

    private IEnumerator Spawner(Vector3 Pos)
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        yield return wait;
        Instantiate(collectablesPrefabs, Pos, Quaternion.identity);
    }

    public void StartNewCoroutine(Vector3 newPos)
    {
        StartCoroutine(Spawner(newPos));
    }
}
