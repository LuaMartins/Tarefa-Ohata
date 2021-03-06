using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube2 : MonoBehaviour
{
    public GameObject target2;
    void Start()
    {

    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target2.transform.position, 10f * Time.deltaTime);
    }
}
