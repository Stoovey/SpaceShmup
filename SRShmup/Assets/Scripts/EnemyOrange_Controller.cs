using UnityEngine;
using System.Collections;

public class EnemyOrange_Controller : MonoBehaviour
{
    //SerialzeField keeps the variable private but allows you to see
    //it in the inspector.
    public float m_speed = 5f;
    Transform m_transform;
    [SerializeField]
    GameObject OrangeEnemy;
    [SerializeField]
    GameObject enemyBullet;
    [SerializeField]
    Transform enemyBulletSpawner;
    int counter;
    int count;


    void Start()
    {
        counter = 0;
        m_transform = GetComponent<Transform>();
        m_transform.Rotate(0.0f, 0.0f, 90.0f);
        transform.Find("BulletSpawn");
    }

    void Update()
    {
      //Moving the enemy orange ship on the deltaX axis in a small zig zag form.
        float deltaX = 0.05f;
        m_transform.Translate(new Vector3(-deltaX, 0.0f, 0.0f) * m_speed, Space.World);
            ++count;
            if(count > 80)
            {
                count = 0;
            }
            if (count >= 41)
            {
                m_transform.Translate(new Vector3(0.0f, -1.0f, 0f) *Time.deltaTime * m_speed, Space.World);
            }
            else if (count <= 39)
            {
                m_transform.Translate(new Vector3(0.0f, 1.0f, 0f) *Time.deltaTime * m_speed, Space.World);
            }

            if(count == 12 || count == 67)
            {
            // If count is equal to 12 or 67, shoot 
            Instantiate(enemyBullet, enemyBulletSpawner.position, Quaternion.identity);
            }

        }
   
    //Should destroy the enemy/PlayerBullet 
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
        }

    }
    //When it leaves the Camera it should despawn - I need to look into this because 
    //Not sure why it does not destroy the game object.
    void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
}    

