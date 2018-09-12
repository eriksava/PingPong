using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    int hitcounter = 0;


	void Start () {
        StartCoroutine(this.StarBall());
	}

    public IEnumerator StarBall(bool isStartingPLayer1 = true){

        this.hitcounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPLayer1)
            this.MoveBall(new Vector2(-1, 0));
        else{
            this.MoveBall(new Vector2(1, 0));
        }
    }
	
    public void MoveBall(Vector2 dir){

        dir = dir.normalized;

        float speed = this.movementSpeed + this.hitcounter * extraSpeedPerHit;

        Rigidbody2D cuerpoRigido2D = this.gameObject.GetComponent<Rigidbody2D>();

        cuerpoRigido2D.velocity = dir * speed;

    }


   
}
