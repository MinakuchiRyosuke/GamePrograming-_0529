using UnityEngine;
using System.Collections.Generic;

public class Point : MonoBehaviour
{
    [SerializeField] private LayerMask stageLayer;
    public List<Vector2> Directions;

    private void Start()
    {
        Directions = new List<Vector2>();

        CheckDirection(Vector2.up);
        CheckDirection(Vector2.down);
        CheckDirection(Vector2.left);
        CheckDirection(Vector2.right);
    }

    private void CheckDirection(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast
            (this.transform.position, Vector2.one * 0.5f, 0.0f, direction, 1.0f, this.stageLayer);

        if(hit.collider == null)
        {
            Directions.Add(direction);
        }
    }
}
