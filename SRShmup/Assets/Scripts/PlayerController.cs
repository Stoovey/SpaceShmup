using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float m_playerSpeed = 5f;
    public Transform m_BulletSpawner;
    Transform m_transform;
    public GameObject m_bulletPrefab;
    public int count;
    public float speed;
    public float touchInput;


	// Use this for initialization
	void Start () {
        m_transform = GetComponent<Transform>();
        transform.Find("BulletSpawn");
        count = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Keyboard Input 

        ++count;

        float deltaY = 0f;

        if ( Input.GetKey(KeyCode.W))
        {
            deltaY -= 1f;
            Debug.Log("Going Up");
        }

        if ( Input.GetKey(KeyCode.S))
        {
            deltaY += 1f;
            Debug.Log("Going Down");
        }
        //Dont re-enable unless you want admin powers
        //Instantiate(m_bulletPrefab, m_BulletSpawner.position, Quaternion.identity);


        m_transform.Translate(new Vector3(deltaY, 0f, 0f) * Time.deltaTime * m_playerSpeed);


        if (Input.touchCount > 0)
        {
            touchInput = transform.position.y + Input.GetTouch(0).deltaPosition.y * speed;
        }
             if (Input.touchCount > 0)
        {       
            Instantiate(m_bulletPrefab, m_BulletSpawner.position, Quaternion.identity);
        }
       if(count > 60)
        {
            count = 0;
        }
	}
}
