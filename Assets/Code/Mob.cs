using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public MobStats mob_stats;
    public Vector2[] positions;
    public bool inside = false;

    void Awake()
    {
        mob_stats = FindObjectOfType<Game>().getRandomMobStats();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
