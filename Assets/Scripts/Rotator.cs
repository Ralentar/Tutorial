using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 90;

    private void Update()
    {
        transform.Rotate(Vector3.up, _speed * Time.deltaTime);
    }
}