using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed = 5;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
}
