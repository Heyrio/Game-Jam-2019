using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int hour = 0;
    public int day = 0;
    private float time = 0f;
    private int time_diff = 7;
    public List<Mob> mob_list;

    private static string[] names = {
    "Fernanda",
    "Jamal",
    "Darrell",
    "Suzette",
    "Cindy",
    "Jo",
    "Jame",
    "Lecia",
    "Vern",
    "Coralie",
    "Liane",
    "Pearline",
    "Aisha",
    "Rex",
    "Stefani",
    "Heide",
    "Bebe",
    "Ping",
    "Milo",
    "Collin",
    "Salley",
    "Marlyn",
    "Melissia",
    "France",
    "Madelene",
    "Star",
    "Mathilde",
    "Gigi",
    "Mellisa",
    "Tonda",
    "Georgette",
    "Marcel",
    "Trudi",
    "Vita",
    "Katharyn",
    "Antone",
    "Lashaun",
    "Darin",
    "Sook",
    "Ty",
    "Christopher",
    "Un",
    "Latrici",
    "Sharon",
    "Milton",
    "Janeth",
    "Mickey",
    "Dario",
    "Willard" };

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > time_diff)
        {
            time = 0;
            hour++;
            if(hour > 24)
            {
                hour = 0;
                day++;
            }
        }
    }

    public void addMob(Mob mob)
    {
        mob_list.Add(mob);
    }

    public static string getRandomName()
    {
        return names[Random.Range(0, 49)];
    }
}
