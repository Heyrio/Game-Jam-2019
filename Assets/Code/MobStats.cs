using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mob", menuName = "ScriptableObjects/Mob", order = 1)]
public class MobStats : ScriptableObject
{
    readonly public int age = Random.Range(18, 44);
    public Sprite sprite;
    public Vector2 favorite_time;
    public int worth;
}
