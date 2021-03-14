﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawner : MonoBehaviour
{
    float spawnFrequency;
    public float startspawnFrequency;
    public GameObject Prefab;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnFrequency <= 0)
        {
            Instantiate(Prefab, transform.position, Quaternion.identity);
            spawnFrequency = startspawnFrequency;
        }
        else
        {
            spawnFrequency -= Time.deltaTime;
        }
    }
}
