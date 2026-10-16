using UnityEngine;

public class Crystal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, есть ли у объекта, который коснулся кристалла, компонент Collector
        if (other.TryGetComponent<Collector>(out Collector collector))
        {
            // Вызываем метод добавления кристалла у игрока
            collector.AddCrystal();

            // Уничтожаем объект кристалла, чтобы он исчез со сцены
            Destroy(gameObject);
        }
    }
}
