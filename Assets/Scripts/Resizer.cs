using UnityEngine;

public class Resizer : MonoBehaviour
{
    [SerializeField] private float _increaseRate = 0.1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _increaseRate * Time.deltaTime;      
    }
}