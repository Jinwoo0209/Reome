using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 8f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "wall_2")
        {
            Destroy(gameObject);
        }
    }
}
