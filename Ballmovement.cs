using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float movespeed;
    public float extraspeedperhit;
    public float maxspeed;
    int hitcounter = 0;

    void Start()
    {
        StartCoroutine(this.Startposition());
    }

    public IEnumerator Startposition(bool isStartingplayer1 = true)
    {
        this.hitcounter = 0;
        yield return new WaitForSeconds(3);
        if (isStartingplayer1)
        {
            this.Moveball(new Vector2(-1, 0));

        }
        else
        {
            this.Moveball(new Vector2(1, 0));
        }
    }

    public void Moveball(Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.movespeed + this.hitcounter * this.extraspeedperhit;

        Rigidbody2D rigid = this.gameObject.GetComponent<Rigidbody2D>();
        rigid.velocity = dir * speed;
    }
    public void increasecounter()
    {
        if (this.hitcounter * this.extraspeedperhit <= this.maxspeed)
        {
            this.hitcounter++;
        }
    }

}

