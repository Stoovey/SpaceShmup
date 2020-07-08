using UnityEngine;
using System.Collections;

public class EnemySpawnerMiddle : MonoBehaviour
{

    public int count;
    public GameObject Enemy2;
    public Transform m_transform;
    public int counter;
    public int m_speed;
    
    

    // Use this for initialization
    void Start()
    {
        m_transform = GetComponent<Transform>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {

           ++counter;
            ++count;
        if (counter > 80)
        {
            counter = 0;
        }
        if (counter >= 37)
        {
            m_transform.Translate(new Vector3(1f, 1f, 0f) * Time.deltaTime * m_speed);
        }
        else if (counter <= 42)
        {
            m_transform.Translate(new Vector3(-1f, 2f, 0f) * Time.deltaTime * m_speed);
        }




        if (count == 60)
        {
            //Enable Enemy 2 which in this case is Orange Ship.
            Instantiate(Enemy2, m_transform.position, Quaternion.identity);
           
        }

        if (count == 100)
        {
            count = 0;
        }
        
        
        
    }
}
