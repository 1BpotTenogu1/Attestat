using UnityEngine;
using UnityEngine.UI;

public class TextEat : MonoBehaviour
{
    public Text Text;
    public Snake Snake;

    void Update()
    {
        Text.text = Snake.Eat.ToString();
        Debug.Log("Top:  ");
    }
}
