using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb;
    public GameObject Turret;
    public GameObject Missle;
    public float Missleforce;
    public float MissleDeathTime;
    public float lastMissle;
    public float Timer = 0.5f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Movement();
        Shoot();
	}

    private void Movement()
    {
        float hAxis = Input.GetAxis("Horizontal");


        Vector3 movment = new Vector3(hAxis, 0) * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movment);
        //rb.AddForce(movment);
    }

   private void Shoot()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > lastMissle + Timer)
            {
                GameObject tempBullet;
                tempBullet = Instantiate(Missle, Turret.transform.position, Turret.transform.rotation) as GameObject;

                lastMissle = Time.time;

                Rigidbody2D tempRigidbdy;
                tempRigidbdy = tempBullet.GetComponent<Rigidbody2D>();

                tempRigidbdy.AddForce(transform.up * Missleforce);

                Destroy(tempBullet, MissleDeathTime);
            }
        }
    }
}
