using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_script : MonoBehaviour
{
    public float HP = 3;
    private Rigidbody _rigedbody; 
    public float Force = 1;
    public float ForceOnStay = 1;
    public float RelativeForce = 1;
    public Text HpScore;
    public GameObject DestroyEffect;

    private void Awake()
    {
        _rigedbody = GetComponent<Rigidbody>();
    }
    public void OnHit()
    {
        HP -= 1;
        GetComponent<Rigidbody>().AddForce(Vector3.up * -FindObjectOfType<Bomb_script>().ForceExplosion);
        HpScore.text = "Health: " + HP.ToString() + " "; 

    }
    public void OnGround()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 120f);

    }
    public void Update()
    {
        if (HP == 0)
        {
            gameObject.SetActive(false);
            Instantiate(DestroyEffect, transform.position, transform.rotation);
        }
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    transform.rotation = new Quaternion(0, 0, 180f, RelativeForce);
        //}
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    transform.rotation = new Quaternion(0, 0, 0, RelativeForce);
        //}
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigedbody.AddRelativeForce(0f, 0f, Force, ForceMode.Acceleration);
        }
        else
        {
            _rigedbody.AddRelativeForce(0f, 0f, ForceOnStay, ForceMode.Acceleration);
        }
        float sideforce = Input.GetAxis("Horizontal") * RelativeForce;
        _rigedbody.AddRelativeTorque(sideforce, 0f, 0f);

       
    }
}
