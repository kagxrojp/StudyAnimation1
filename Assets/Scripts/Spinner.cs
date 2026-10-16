using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Вместо float используем Vector3, чтобы в Инспекторе появились три поля: X, Y и Z
    [SerializeField] private Vector3 _rotationSpeed = new Vector3(0f, 90f, 0f);

    void Update()
    {
        // Умножаем весь вектор скорости на Time.deltaTime для плавности
        // и передаем его в метод Rotate
        transform.Rotate(_rotationSpeed * Time.deltaTime);
    }
}
