using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    float nilai;
    // Start is called before the first frame update
    void Start()
    {
        nilai = Random.Range(-3.80f, 1.92f);
        transform.position = new Vector2(transform.position.x, nilai);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 5);
    }
}
