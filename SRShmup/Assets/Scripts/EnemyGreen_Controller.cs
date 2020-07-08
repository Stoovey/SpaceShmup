using UnityEngine;
using System.Collections;

public class EnemyGreen_Controller : MonoBehaviour
{

    Transform m_transform;
    public GameObject m_bulletPrefab;
    public GameObject m_BulletSpawner;
    public GameObject GreenEnemy;
    public float m_speed = 5f;
    public int counter;


    void Start()
    {
        counter = 0;
  
        transform.Rotate(0f, 0f, 90f);
        m_transform = GetComponent<Transform>();
        m_BulletSpawner = transform.Find("BulletSpawn").gameObject;
        counter++;
    }

    void Update()
    {
        if (counter == 100)
        {
            GameObject clone;
            clone = (GameObject)Instantiate(m_bulletPrefab, m_BulletSpawner.transform.position, transform.rotation);
            counter = 0;
        }
        m_transform.Translate(new Vector3(-1f, 0, 0f) * Time.deltaTime * m_speed, Space.World);
        counter++;
     }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
        }

    }

    void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
}
