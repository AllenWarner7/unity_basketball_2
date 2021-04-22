using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployballs : MonoBehaviour
{
    public GameObject ballPrefab;
    public float respawnTime = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(newBall());
    }
    private void spawnBall()
    {
        GameObject ball = Instantiate(ballPrefab) as GameObject;
    }
    IEnumerator newBall()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBall();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
