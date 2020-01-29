using UnityEngine;

public class XMLDeserializer : MonoBehaviour
{
    private void Start()
    {
        Hero hero = XMLOp.Deserialize<Hero>("hero.xml");
        Debug.Log(hero.name);
    }
}
