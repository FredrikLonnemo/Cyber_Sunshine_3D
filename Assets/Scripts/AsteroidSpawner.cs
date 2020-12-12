using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public List<GameObject> pooledAsteroids;
    public GameObject asteroidPrefab;
    public int maxAsteroids;

    private readonly float chanceForLast = 0.01f; // not sure if this is useful anymore

    public float smallRadius;
    public float bigRadius;

    public Vector3 destination;

    public int timer = 0;
    //public int timerMax = 250;

    public int spawnTimer = 0;
    //public int spawnMax = 250;

    public int difficulity = 0;
    //public float diffMult = 5;
    //public int maxDifficulity = 35;

    public ValuesObject gameValues;
    private void Start()
    {
        pooledAsteroids = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < maxAsteroids; i++)
        {
            tmp = Instantiate(asteroidPrefab);
            AsteroidScript astScript = tmp.GetComponent<AsteroidScript>();
            astScript.target = destination;
            tmp.SetActive(false);
            pooledAsteroids.Add(tmp);
        }

        difficulity = gameValues.startDifficulity;
    }

    public GameObject GetAsteroid()
    {
        for (int i = 0; i < maxAsteroids; i++)
            if (!pooledAsteroids[i].activeInHierarchy)
            {
                if (i == maxAsteroids - 1 && chanceForLast > Random.Range(0.0f, 1.0f))
                    return null;

                return pooledAsteroids[i];
            }

        return null;
    }

    private void FixedUpdate()
    {
        timer++;
        spawnTimer++;
        if (spawnTimer > gameValues.spawnMax - (difficulity * gameValues.diffMult))
        {
            spawnTimer = 0;
            //get random point
            Vector3 posInSphere = Random.insideUnitSphere;
            float length = posInSphere.magnitude;
            float ratioRadius = smallRadius / bigRadius;
            Vector3 spawnPosition = (((1.0f - ratioRadius) * length + ratioRadius) / length) * bigRadius * posInSphere;
            //spawn an asteroid
            GameObject spawnedAsteroid = GetAsteroid();
            if (spawnedAsteroid != null)
            {
                spawnedAsteroid.transform.position = spawnPosition;
                spawnedAsteroid.SetActive(true);
            }
        }

        if(timer > gameValues.timerMax)
        {
            timer = 0;
            if (difficulity < gameValues.maxDifficulity)
                difficulity++;
        }
    }
}
