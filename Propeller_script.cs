using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller_script : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0, 45 * Time.deltaTime * 100, 0) ;
    }
}
