using UnityEngine;

[CreateAssetMenu(fileName = "MenuItem", menuName = "Scriptable Objects/MenuItem")]
public class MenuItem : ScriptableObject
{
    public CoffeeIngredients[] CoffeeIngredients;
}
