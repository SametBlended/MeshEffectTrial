﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTheGuy : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
