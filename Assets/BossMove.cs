using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //“G‚Ìƒ[ƒ‹ƒhÀ•W‚ðŽæ“¾
        Vector3 pos = transform.position;

        if(pos.z >= 15)
        {
            pos.z -= speed;
        }
        else
        {
            pos.x -= speed;
            if(pos.x <= -15)
            {
                speed = -speed;
            }
            else if (pos.x >= 15)
            {
                speed = -speed;
            }
        }

        transform.position = pos;
    }
}
