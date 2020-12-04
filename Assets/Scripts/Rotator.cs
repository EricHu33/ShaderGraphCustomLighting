using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private int m_angle = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_angle++;
        if (m_angle >= 360)
        {
            m_angle = 0;
        }
        transform.RotateAround(transform.position, Vector3.up, 1);
    }
}
