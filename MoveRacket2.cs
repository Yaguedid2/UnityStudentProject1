using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket2 : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
    }
}
