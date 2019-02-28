using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCam : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float nextpos = Lerp(transform.position.x, player.transform.position.x, Time.deltaTime * 2f);

        if(Mathf.Abs(nextpos) < 0.025f)
        {
            nextpos = 0;
        }

        transform.position = new Vector3(nextpos, transform.position.y, transform.position.z);
    }

    float LerpVelocity(float position, float target, float amount)
    {
        return (target - position) * amount;
    }

    float Lerp(float position, float target, float amount)
    {
        float v = LerpVelocity(position, target, amount);
        if (v == 0) return 0;
        if (position + v <= 0 || position + v >= 57) v = 0;

        position = position + v;
        return position;
    }
}
