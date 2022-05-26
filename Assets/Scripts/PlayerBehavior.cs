using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public GameObject prefab, spawnPoint;
    GameObject clone;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clone = Instantiate(prefab);
            clone.transform.position = spawnPoint.transform.position - Vector3.forward;
        }
    }
}
