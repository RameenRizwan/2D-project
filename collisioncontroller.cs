using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioncontroller : MonoBehaviour
{
    public ballMovement ballmove;
    public Scoring scoring;

    public void bounceOfRacket(Collision2D c)
    {
        Vector3 ballposition = this.transform.position;
        Vector3 racketpostion = c.gameObject.transform.position;

        float racketheight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "player1")
        {
            x = 1;
        }
        else { x = -1; }

        float y = (ballposition.y - racketpostion.y) / racketheight;

        this.ballmove.increasecounter();
        this.ballmove.Moveball(new Vector2(x, y));

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "player1" || coll.gameObject.name == "player2")
        {
            this.bounceOfRacket(coll);
        }
        else if (coll.gameObject.name == "wallright")
        {
            Debug.Log("Collision on right wall");
            this.scoring.Goalplayer1();
        }
        else if (coll.gameObject.name == "wallleft")
        {
            Debug.Log("Collision on Left wall");
            this.scoring.Goalplayer2();
        }
    }
}

