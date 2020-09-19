using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshInstatior : MonoBehaviour
{
    void Update()
    {
        UnityEngine.AI.NavMeshHit closestHit;

        if (UnityEngine.AI.NavMesh.SamplePosition(gameObject.transform.position, out closestHit, 500f, UnityEngine.AI.NavMesh.AllAreas))
            gameObject.transform.position = closestHit.position;
        else
            Debug.LogError("NavMesh üstünde bir konum bulunamadı");
    }
}
