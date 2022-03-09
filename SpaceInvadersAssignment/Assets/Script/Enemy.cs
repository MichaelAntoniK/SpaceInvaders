using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour {

    //public List<GameObject> prefabs = new List<GameObject>();

    //public Transform top;
    //public Transform bottom;

    //public Transform right;
    //public Transform left;
    public Transform enemyPos;
    public float speed;
    //public int enemyAmount = 39;
  

    // Use this for initialization
    void Start() {
        //float screenHeight = bottom.transform.position.y - top.transform.position.y;
        //float halfScreenHeightPos = bottom.transform.position.y - screenHeight / 2;


        //for (int i = 0; i < 10; ++i)
        //{
        //    float randoY = Random.Range(halfScreenHeightPos, top.transform.position.y);
        //    float randoX = Random.Range(left.transform.position.x, right.transform.position.y);
        //    Debug.Log("randoX:" + randoX);
        //    GameObject enemy = prefabs[Random.Range(0, 3)];

        //    Instantiate(enemy, new Vector3(i , randoY, 0), Quaternion.identity);
        //}
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemyPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            SceneManager.LoadScene("YouWin");
        }
    }

    //public void SetSpawner(EnemySpawner spawner)
    //{
    //    this.SetSpawner = spawner;
    //}


    //private void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.tag == "Missle")
    //    {
    //        Destroy(col.gameObject);
    //        Destroy(gameObject);
    //        Debug.Log("Hit");
    //    }
    //}
    public void MoveEnemy()
    {
        enemyPos.position += Vector3.right * speed;
        foreach (Transform enemy in enemyPos)
        {
            if(enemy.position.x < -12.54 || enemy.position.x > 12.55)
            {
                speed = -speed;
                enemyPos.position += Vector3.down * 1f;
                return;
            }
            
            if (enemy.position.y <= -3.21)
            {
                Time.timeScale = 0;
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    //public void Drop()
    //{
    //    transform.position += Vector3.down * 0.5f;
    //}
}