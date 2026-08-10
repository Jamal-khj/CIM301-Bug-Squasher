using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] bugs;
    public Vector2 spawnValues;
    public float yPositionForSpwaner;
    public float spawnWait;
    public float spawnMaxTime;
    public float spawnMinTime;
    public int startWait;
    public bool stop;

    // Spawn rate variables
    public float spawnTimerDown;
    public float timerDownAmount;
    public float lowestMaxTimer;
    public float lowestMinTimer;
    public float reduceAmount;

    // Variable for random bugs
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

        spawnTimerDown += Time.deltaTime;

        if (spawnTimerDown >= timerDownAmount)
        {
            if(spawnMaxTime > lowestMaxTimer)
            {
                LowerMax(reduceAmount);
            }
            if(spawnMinTime > lowestMinTimer)
            {
                LowerMin(reduceAmount);
            }
            spawnTimerDown = 0;
        }
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randBug = Random.Range(0, bugs.Length);

            Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), yPositionForSpwaner);

            Instantiate(bugs[randBug], spawnPosition, gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }

    public void LowerMax(float amount)
    {
        spawnMaxTime -= amount;
    }

    public void LowerMin(float amount)
    {
        spawnMinTime -= amount;
    }
}