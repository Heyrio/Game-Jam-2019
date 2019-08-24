using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public MobStats mob_stats;
    public Vector2[] positions;
    public bool inside = false;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = mob_stats.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
