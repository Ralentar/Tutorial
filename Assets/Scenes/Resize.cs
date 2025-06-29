using UnityEngine;

public class Resize : MonoBehaviour
{
    [SerializeField] private float _increaseRate = 0.1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _increaseRate * Time.deltaTime;      
    }
}