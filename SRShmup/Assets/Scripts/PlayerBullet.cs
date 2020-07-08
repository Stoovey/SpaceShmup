using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

    public float m_speed = 7f;
    public Transform m_transform;

    // Use this for initialization
    void Start() {
        m_transform = GetComponent<Transform>();
        //Rotating the player bullet towards the enenmy spawners.
        m_transform.Rotate(new Vector3(0, 0, 90));
	}
	
	// Update is called once per frame
	void Update () {
        //Moviing the player bullet to the right and keeping it inline with Space.World (gameworld)
        m_transform.Translate(new Vector3(1f, 0f, 0f) * Time.deltaTime * m_speed, Space.World);

	}
    //Delete the gameobject - Need to look into 
    void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
    //If comes into contact with Enemy. Delete.
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

    }
}
