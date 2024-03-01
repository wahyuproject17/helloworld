using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;

    float score;

    public Text scoreTxt;
    public float speed = 30;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreTxt.text = "" + score;
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag=="point"){
            score++;
        }
        if(collision.gameObject.tag == "trap"){
            Destroy(gameObject);
        }
    }
}
