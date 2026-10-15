using UnityEngine;

[CreateAssetMenu(fileName = "CoffeeShopData", menuName = "Scriptable Objects/CoffeeShopData")]
public class CoffeeShopData : ScriptableObject
{
    public string coffeeName;
    public Sprite coffeeIcon;
    public int value;
    public CoffeeShopMenu menu;
}
