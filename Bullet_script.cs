using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_script : MonoBehaviour
{
    private float _timer;
    public float _bulletLifetime = 3;
    public void OnCollisionEnter(Collision collision)
    {
        Bomb_script EnemyIsBomb = collision.gameObject.GetComponent<Bomb_script>();
        Rocket_script EnemyIsRocket = collision.gameObject.GetComponent<Rocket_script>();
        if (EnemyIsBomb)
        {
            EnemyIsBomb.BombDestroy();
            Destroy(gameObject);
        }
        else if (EnemyIsRocket)
        {
            EnemyIsRocket.RocketDestroy();
            Destroy(gameObject);
        }
        
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _bulletLifetime)
        {
            Destroy(gameObject);
        }
    }
}
