﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LawnMower : MonoBehaviour
{
    public GameObject prefab;
    void LateUpdate()
    {
        Instantiate(prefab, new Vector3(transform.position.x, transform.position.y - .1f, transform.position.z), Quaternion.identity);
    }
}
