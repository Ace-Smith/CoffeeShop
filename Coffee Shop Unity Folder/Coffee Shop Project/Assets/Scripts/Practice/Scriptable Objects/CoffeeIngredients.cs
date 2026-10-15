using UnityEngine;

public enum Allergies
{
    Milk,
    Gluten
}

[CreateAssetMenu(fileName = "CoffeeIngredients", menuName = "Scriptable Objects/CoffeeIngredients")]
public class CoffeeIngredients : ScriptableObject
{
    public float price;
    public int quantity;
    public bool inStock;
    public int quantityAvailableInShop;
    public Allergies[] allergies;
}
