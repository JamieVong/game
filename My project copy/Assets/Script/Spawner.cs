using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject[] plastics;
    public GameObject[] fish;

    public float xBounds, yBound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());

    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1,2));

        int randomPlastic = Random.Range(0,plastics.Length);
        int randomFish = Random.Range(0,fish.Length);

        if(Random.value <= .6f)
            Instantiate(plastics[randomPlastic],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        else
            Instantiate(fish[randomFish],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        
        StartCoroutine(SpawnRandomGameObject());
    }
    
}
