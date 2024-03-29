using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName ="Scriptable object/Item")]
public class Item : ScriptableObject
{

    [Header ("Only gameplay")]
    public TileBase Tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range =new Vector2Int(5, 4);

    [Header("only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;
}

public enum ItemType
{
    BuildingBlock,
    Tool,
    Food,
    Weapon,
    Armor
}

public enum ActionType
{
    Dig,
    Mine,
    Attack,
    Protect,
    Statiate,
    Regenerate
}
