using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_script : MonoBehaviour
{
    //1. Наносить урон игроку.
    //2. Отбрасывать игрока
    //3. Уничтожаться.
    //4. Рандомно располагаться на карте.
    public float ForceExplosion;

    public GameObject BangEffect;

    private void OnCollisionEnter(Collision collision)
    {
        Player_script enemy = collision.gameObject.GetComponent<Player_script>();
        if (enemy)
        {
            enemy.OnHit();
            BombDestroy();
        }
    }
    public void BombDestroy()
    {
        Instantiate(BangEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
