using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobQueue : MonoBehaviour
{
    public Mob current_mob;
    public List<Mob> mob_queue;
    public float choose_timer = 30f;
    public int max_choose_timer = 30;
    // Start is called before the first frame update
    void Start()
    {
        choose_timer = max_choose_timer;
    }

    // Update is called once per frame
    void Update()
    {
        if(current_mob != null)
        {
            choose_timer -= Time.deltaTime;
            if(choose_timer < 0f)
            {
                Debug.Log("LOSE");
            }
        }
    }

    public void updateCurrent()
    {
        if (mob_queue.Count > 0)
        {
            current_mob = mob_queue[0];
        }
        else
        {
            current_mob = null;
        }
        choose_timer = max_choose_timer;
    }

    //important events
    public void acceptCurrent()
    {
        if (current_mob != null) {
            FindObjectOfType<Game>().addMob(current_mob);
            mob_queue.Remove(current_mob);
            choose_timer = max_choose_timer;
            updateCurrent();
        }
    }

    public void denyCurrent()
    {
        if (current_mob != null)
        {
            mob_queue.Remove(current_mob);
            choose_timer = max_choose_timer;
            updateCurrent();
        }
    }
}
