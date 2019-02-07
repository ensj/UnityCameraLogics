using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    GameObject player;
    PlayerMovement script;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        script = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > transform.position.x + 3)
        {
            if (transform.position.x < 57)
            {
                transform.Translate(new Vector2(player.transform.position.x - transform.position.x - 3,0));
            }
        }else if(player.transform.position.x < transform.position.x - 3)
        {
            if (transform.position.x > 0)
            {
                transform.Translate(new Vector2(player.transform.position.x - transform.position.x + 3, 0));
            }
        }
    }
}
