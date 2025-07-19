using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private bool _isWork = false;
    private float _currentValue = 0f;
    private float _step = 0.5f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == false)
            return;

        _isWork = !_isWork;

        if (_isWork)
            StartCoroutine(Count());
    }

    private IEnumerator Count()
    {
        var wait = new WaitForSeconds(_step);

        while (_isWork)
        {
            _currentValue++;
            Debug.Log($"{Time.time} :: Текущее значение счетчика: {_currentValue}");
            yield return wait;
        }
    }
}
