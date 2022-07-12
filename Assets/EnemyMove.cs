using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //“G‚Ìƒ[ƒ‹ƒhÀ•W‚ğæ“¾
        Vector3 pos = transform.position;

        pos.z -= speed;

        transform.position = pos;
    }
}
