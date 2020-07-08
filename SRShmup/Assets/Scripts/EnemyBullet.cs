using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour
{

    public float m_speed = 10f;

    void Start()
    {
        transform.Rotate(0.0f, 0.0f, 90.0f);
    }

    void Update()
    {
        transform.Translate(0.0f, m_speed * Time.deltaTime, 0.0f);
    }
    //Should die when out of camera
    void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
    //when collided with Player, die.
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }

}