﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    public BallMovement ballMovement;

    void BounceFromRacket(Collision2D c){

        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHight = c.collider.bounds.size.y;
        float x;
        if (c.gameObject.name == "RacketPLayer1")
        {

            x = 1;
        }
        else{
            x = -1;
            }

        float y = (ballPosition.y - racketPosition.y) / racketHight;


        //this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRacket(collision);

        }else if(collision.gameObject.name == "WallLeft"){
            Debug.Log("Collision with Wall left");
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collision with Wall Right");
        }
    }
}

