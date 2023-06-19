using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_spawner_script : MonoBehaviour
{


    public GameObject CoinToSpawn;
    public GameObject BombToSpawn;
    public GameObject RocketToSpawn;
    public float NextRocketStartTime = 12f;

    void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            Quaternion Ro = Quaternion.Euler(0, 0, 90f);
            Vector3 Position = new Vector3(0, Random.Range(-45f, 45f), Random.Range(-145f, 145f));
            Instantiate(CoinToSpawn, Position, Ro);
        }
        for (int i = 0; i < 20; i++)
        {
            Vector3 Position = new Vector3(0, Random.Range(-45f, 45f), Random.Range(-145f, 145f));
            Instantiate(BombToSpawn, Position, Quaternion.identity);
        }
        
        
    }
    private void Update()
    {
        if (Time.time > NextRocketStartTime)
        {
            Vector3 Position = new Vector3(0f, 110f, Random.Range(-250, 250));
            Instantiate(RocketToSpawn, Position, Quaternion.identity);
            NextRocketStartTime += 12f;
        }
    }
}
    

    



  
