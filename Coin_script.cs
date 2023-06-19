using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_script : MonoBehaviour
{

    public GameObject CoinSound;
    public Score Score;
    
    // Start is called before the first frame update
    void Start()
    {
        Score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(45 * Time.deltaTime, 0f, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        Player_script Player = other.gameObject.GetComponent<Player_script>();
        if (Player)
        {
            Instantiate(CoinSound, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Score.AddOne();
        }


    }

}
