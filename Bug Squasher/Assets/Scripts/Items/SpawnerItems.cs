using System.Collections;
using UnityEngine;

public class SpawnerItems : MonoBehaviour
{
    public GameObject[] items;
    public Vector2 spawnValues;
    public float yPositionForSpwaner;
    public float spawnWait;
    public float spawnMaxTime;
    public float spawnMinTime;
    public int startWait;
    public bool stop;

    int randBug;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnMinTime, spawnMaxTime);
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randBug = Random.Range(0, items.Length);

            Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), yPositionForSpwaner);

            Instantiate(items[randBug], spawnPosition, gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}