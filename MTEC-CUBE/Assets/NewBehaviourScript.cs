using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
// Instantiates 10 copies of Prefab each 2 units apart from each other
{
    public GameObject prefab;
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);
        }
    }
}