using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Script : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        Player_script enemy = collision.gameObject.GetComponent<Player_script>();
        if (enemy)
        {
            enemy.OnGround();
        }
    }
}
