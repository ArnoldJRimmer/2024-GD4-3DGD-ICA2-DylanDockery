using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Creates a Grid layout this will help in the brief
/// Code belongs to Ben Mcquaile and i was given access 25/04/2024
/// </summary>
public class GridLayout : MonoBehaviour
{
    [SerializeField] private Vector2 range = new(100, 100);
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(range.x, 5f, range.y));
    }
}
