using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_script : MonoBehaviour
{
    public GameObject BulletPrehab;
    public float BulletSpeed;
    public AudioSource ShotSound;
    public float ShotDelay = 0.15f;
    private float _timer;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
            if (_timer > ShotDelay)
            {
                _timer = 0;
                CreateBullet();
            }

    }
    void CreateBullet()
    {
        GameObject newBullet = Instantiate(BulletPrehab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
        ShotSound.pitch = Random.Range(0.9f, 1.1f);
        ShotSound.Play();
    }
}
