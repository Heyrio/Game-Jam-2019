using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mob", menuName = "ScriptableObjects/Mob", order = 1)]
public class Mob : ScriptableObject
{
    readonly public string name = Game.getRandomName();
    readonly public int age = Random.Range(18, 44);
    public Sprite sprite;
    // Start is called before the first frame update
 
}
