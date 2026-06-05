using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private LayerMask stageLayer;
    [SerializeField] private Eye eye;

    private Rigidbody2D rb;
    private float speed = 7.5f;
    private Vector2 _direction;
    private Vector2 _directionReserve;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _direction = Vector2.left;
    }

    private void Update()
    {
        if(_directionReserve != Vector2.zero)
        {
            CheckDirection(_directionReserve);
        }
    }

    private void FixedUpdate()
    {
        Vector2 dist = _direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + dist);
    }

    private void CheckDirection(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast
            (transform.position, Vector2.one * 0.5f, 0.0f, direction, 1.0f, stageLayer);

        if(hit.collider == null)
        {
            _direction = direction;
            eye.ChangeEye(direction);
            _directionReserve = Vector2.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Point point = other.GetComponent<Point>();

        if(point != null)
        {
            int index = Random.Range(0, point.Directions.Count);
            _directionReserve = point.Directions[index];
        }
    }
}
