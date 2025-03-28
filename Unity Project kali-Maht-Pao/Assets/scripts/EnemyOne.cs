using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class EnemyOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        transform.Rotate(0.0f, 0.0f, 45.0f, Space.Self);
        name = "World";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, -7, 0) * Time.deltaTime * 1f);

        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }

}

