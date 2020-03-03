using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    float m_befPosY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        m_befPosY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float sin = Mathf.Sin(Time.time);
        float cos = Mathf.Cos(Time.time);
        transform.position = new Vector3(cos, sin + m_befPosY, 0);
    }
}
