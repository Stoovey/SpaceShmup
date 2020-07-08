using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public int count;
    public GameObject m_Enemy1;
    public Transform m_transform;

	// Use this for initialization
	void Start () {
        m_transform = GetComponent<Transform>();
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {

        ++count;

        if(count == 80)
        {
            Instantiate(m_Enemy1, m_transform.position, Quaternion.identity);
        }

        if (count == 100)
        {
            count = 0;
        }

	}

}
