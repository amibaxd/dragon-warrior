using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireballHolder : MonoBehaviour
{
    [SerializeField] private Transform enemy;

    // Update is called once per frame
    void Update()
    {
        transform.localScale = enemy.localScale;
    }
}
