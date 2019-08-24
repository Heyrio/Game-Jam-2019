using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobQueue : MonoBehaviour
{
    public Mob current_mob;
    public List<Mob> mob_queue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current_mob = mob_queue[0];
    }

    public void acceptCurrent()
    {

    }

    public void denyCurrent()
    {

    }
}
