using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed = 90;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), _speed * Time.deltaTime);
    }
}