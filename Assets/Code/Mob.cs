using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    //public MobStats mob_stats;
    public bool inside = false;
    public float staying_time;
    public int age;
    public int worth;
    public string[] type;
    public string[] not_like_type;
    public StatsPanel inspect_panel;

    void Awake()
    {
        //randomly generate stats
        staying_time = Random.Range(1, 72) * 4;
        age = Random.Range(15, 80);
        worth = Random.Range(0, 50);
        type = Game.getRandomTypes();
        int likes_age_range_x = Random.Range(15, 80);
        int likes_age_range_y = Random.Range(likes_age_range_x, 80);
        not_like_type = Game.getRandomTypes();
        inspect_panel = GameObject.FindGameObjectWithTag("inspect_panel").GetComponent<StatsPanel>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inside)
        {
            staying_time -= Time.deltaTime;
            if (staying_time < 0)
            {
                FindObjectOfType<Game>().removeMob(this);
            }
        }
    }

    private void OnMouseEnter()
    {
        inspect_panel.mob_to_display = this;
    }

    private void OnMouseExit()
    {
        inspect_panel.mob_to_display = null;
    }

    public void move_mob(Vector2 pos)
    {
        transform.position = pos;
    }
}
