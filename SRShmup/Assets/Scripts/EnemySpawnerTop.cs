using UnityEngine;
using System.Collections;

public class EnemySpawnerTop : MonoBehaviour {

    public int count;
    public GameObject Enemy3;
    public Transform m_transform;
    public int m_speed;
	// Use this for initialization
	void Start ()
    {
        m_transform = GetComponent<Transform>();
        count = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float deltaX = 0.10f;
        m_transform.Translate(new Vector3(-deltaX, 0.0f, 0.0f) * m_speed, Space.World);

        count++;
        if (count == 250)
        {
            //spawning Enemy 3 in this case Blue Ship
            Instantiate(Enemy3, m_transform.position, Quaternion.identity);
        }

        if (count == 250)
        {
            count = 0;
        }
	}
}
