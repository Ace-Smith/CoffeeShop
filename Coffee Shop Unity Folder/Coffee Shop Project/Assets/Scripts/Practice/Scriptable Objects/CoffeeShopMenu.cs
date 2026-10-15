using UnityEngine;

[CreateAssetMenu(fileName = "CoffeeShopMenu", menuName = "Scriptable Objects/CoffeeShopMenu")]
public class CoffeeShopMenu : ScriptableObject
{
    public enum CoffeeType
    {
        Espresso,
        Latte,
        Cappuccino,
        Americano,
        Mocha,
        NitroColdBrew,
        None
    }
    public CoffeeType[] Menu;
}
