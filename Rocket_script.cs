using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_script : MonoBehaviour
{
    public float RocketSpeed = 0.1f;
    public Transform Player;
    public GameObject BangEffect;

    private void OnCollisionEnter(Collision collision)
    {
        Player_script enemy = collision.gameObject.GetComponent<Player_script>();
        if (enemy)
        {
            enemy.OnHit();
            RocketDestroy();
        }
    }
    public void RocketDestroy()
    {
        Instantiate(BangEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void Start()
    {
        Player = FindObjectOfType<Player_script>().gameObject.transform;
    }

    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.position, RocketSpeed * Time.deltaTime);
        Vector3 relativePos = Player.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
