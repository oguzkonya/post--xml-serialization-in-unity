using UnityEngine;

public class XMLSerializer : MonoBehaviour
{
    private void Start()
    {
        Hero knight = new Hero();
        knight.name = "Knight of Solamnia";
        knight.hitPoints = 100;
        knight.baseDamage = 50f;
        knight.isBoss = true;
        knight.comboRewards = new int[] { 1, 3, 5 };

        XMLOp.Serialize(knight, "hero.xml");
    }
}
