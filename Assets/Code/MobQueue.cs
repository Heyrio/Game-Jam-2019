using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobQueue : MonoBehaviour
{
    public Mob current_mob;
    public List<Mob> mob_queue;
    public float choose_timer = 30;
    public int max_choose_timer = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(current_mob != null)
        {
            choose_timer -= Time.deltaTime;
            if(choose_timer < 0f)
            {
                break;
            }
        }
    }

    public void updateCurrent()
    {
        current_mob = mob_queue[0];
        choose_timer = max_choose_timer;
    }

    public void acceptCurrent()
    {

    }

    public void denyCurrent()
    {

    }
}
