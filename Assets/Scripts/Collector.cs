using UnityEngine;

public class Collector : MonoBehaviour
{
    // Приватная переменная для хранения счета. 
    // [SerializeField] позволит вам видеть текущее количество кристаллов прямо в Инспекторе во время игры.
    [SerializeField] private int _crystalCount = 0;

    // Публичное свойство (геттер), чтобы другие скрипты (например, финиш) могли узнать, сколько у нас кристаллов
    public int CrystalCount => _crystalCount;

    // Этот метод вызывается из скрипта самого кристалла (Crystal) при подборе
    public void AddCrystal()
    {
        _crystalCount++;
        Debug.Log($"Кристалл собран! Всего кристаллов в кармане: {_crystalCount}");
    }
}
