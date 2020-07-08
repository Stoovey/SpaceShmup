using UnityEngine;
using System.Collections;

public class EnemyBlue_Controller : MonoBehaviour {

    public float m_speed = 1f;
    Transform m_transform;
    //SerializeField keep the function private but allows you to see the function within the inspector.
    [SerializeField]
    GameObject enemyBullet;
    [SerializeField]
    GameObject enemyBulletSpawner;
    int counter;
    int count;


    //Run once.
    void Start()
    {
        counter = 0;
        count = 0;
        m_transform = GetComponent<Transform>();
        m_transform.Rotate(0f, 0f, 90f);
        enemyBulletSpawner = transform.Find("BulletSpawn").gameObject;
       
    }
    //run every frame.
    void Update()
    {
        if (counter == 100)
        {
            counter = 0;
            GameObject clone;
            //Cloning a game object which has been Instantiated - In this case the enemyBullet to the spawner agaisnt the position of it. 3am commenting, sorry if it don't make sense.
            clone = (GameObject)Instantiate(enemyBullet, enemyBulletSpawner.transform.position, new Quaternion(0.0f,0.0f, 0.7f, 0.7f));
            
        }
        
        counter++;

        //Being path finding.

        if (count > 25)
        {
            m_transform.Translate(new Vector3(0, 5f, 0f) * Time.deltaTime * m_speed);
        }
        else if (count <= 25)
        {
            m_transform.Translate(new Vector3(0, 3f, 0f) * Time.deltaTime * m_speed);
        }

        count++;

        if (count > 81)
        {
            count = 0;
        }
    }

    //When collide with PlayerBullet die.
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
        }

    }
    //Should leave when out of camera.
    void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
}


