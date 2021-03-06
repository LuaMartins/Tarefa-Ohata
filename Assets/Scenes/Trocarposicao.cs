using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trocarposicao : MonoBehaviour
{
    public float velocity;

    public int index = 0;

    public List<GameObject> pontuação;



    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pontuação[index].transform.position, velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pontos"))
        {
            next();

        }

    }

    public void next()
    {
        index++;
        if (index >= pontuação.Count)
        {
            index = 0;
        }



    }
}
