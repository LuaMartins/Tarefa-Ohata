using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube1 : MonoBehaviour
{
    public GameObject target;
    
    void Start()
    {

    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 10f * Time.deltaTime);

        
    }
}
