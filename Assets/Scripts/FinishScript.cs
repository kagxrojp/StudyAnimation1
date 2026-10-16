using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private bool _isFinished = false; // Чтобы время не выводилось многократно, если игрок топчется в триггере

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что в триггер зашел именно игрок (у которого есть скрипт FirstPersonController)
        if (!_isFinished && other.GetComponent<FirstPersonController>() != null)
        {
            _isFinished = true;

            // Получаем время прохождения в секундах
            float completionTime = Time.timeSinceLevelLoad;

            // Выводим результат в консоль. 
            // Спецификатор F2 округляет число до двух знаков после запятой (например: 45.23)
            Debug.Log($"Уровень пройден! Время прохождения: {completionTime.ToString("F2")} сек.");
        }
    }
}
