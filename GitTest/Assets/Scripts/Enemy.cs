﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    float m_befPosY = 0f;
    float m_vec = 1;
    // Start is called before the first frame update
    void Start()
    {
        m_befPosY = transform.position.y;
        m_vec = -1;
    }

    // Update is called once per frame
    void Update()
    {
        float sin = Mathf.Sin(Time.time);
        float cos = Mathf.Cos(Time.time);
        m_befPosY += 0.01f * m_vec;
        transform.position = new Vector3(cos, sin + m_befPosY, 0);

        if(transform.position.y >= 4 || transform.position.y <= -4)
        {
            m_vec *= -1;
        }
    }
}
