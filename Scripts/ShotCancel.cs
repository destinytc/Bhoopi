using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCancel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision)
    {
        if (ScoreTracker.Score > 1 && collision.transform.name == "Ball")
        {
            ScoreTracker.Score -= 1;
        }
    }
}
