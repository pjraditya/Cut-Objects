using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpwaner : MonoBehaviour
{
    public GameObject[] objects;
    public Transform[] spawnPoints;
    public float mindelay = 0.1f;
    public float maxdelay = 2.0f;
    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }
    IEnumerator SpawnObjects()
    {
        while(true)
        {
            float delay = Random.Range(mindelay, maxdelay);
            yield return new WaitForSeconds(delay);
            if(Gamemanager.instance.score>100)
            {
                yield return new WaitForSeconds(Random.Range(0.1f, 1f));
            }
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            int randomobjects = Random.Range(0, objects.Length);
            GameObject objectsspawned = Instantiate(objects[randomobjects], spawnPoint.position, spawnPoint.rotation);
            Destroy(objectsspawned, 3f);
        }
    }
}
