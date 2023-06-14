using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Left_Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    // Update is called once per frame
    void Update()
    { 
        transform.Translate(Vector3.left * Time.deltaTime * 8f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "wall_7")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "wall_3")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "wall_29")
        {
            Destroy(gameObject);
        }
    }
}
