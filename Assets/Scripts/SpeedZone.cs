using UnityEngine;

public class SpeedZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, есть ли на вошедшем объекте компонент FirstPersonController
        if (other.TryGetComponent<FirstPersonController>(out FirstPersonController player))
        {
            // Входим в зону: увеличиваем скорость в 2 раза
            player.SetSpeedMultiplier(2f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Проверяем, что из зоны вышел именно игрок
        if (other.TryGetComponent<FirstPersonController>(out FirstPersonController player))
        {
            // Выходим из зоны: возвращаем обычную скорость (множитель 1)
            player.SetSpeedMultiplier(1f);
        }
    }
}